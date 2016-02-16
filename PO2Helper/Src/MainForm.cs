using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace PO2Helper
{
    public partial class MainForm : Form
    {
        // Class Constants
        private const int maxPo2 = 64;
        // MainForm
        public MainForm()
        {
            InitializeComponent();
        }

        // Text update functions
        private void po2Box_TextChanged( object sender, EventArgs e )
        {
            try
            {
                Int32 power = Convert.ToInt32( po2Box.Text );
                if( power < maxPo2 )
                {
                    updateBoxes( power );
                }
                else
                {
                    po2Box.Clear();
                }
            }
            catch
            {
                // Tried to enter something bad
                po2Box.SelectAll();
            }
        }

        private void shortHandBox_TextChanged( object sender, EventArgs e )
        {
            
        }

        private void shortHandComboBox_SelectedIndexChanged( object sender, EventArgs e )
        {
            if( shortHandComboBox.Items.Contains( shortHandComboBox.Text ) )
            {
                // Do something
            }
            else
            {
                shortHandComboBox.SelectedIndex = 0;
            }
        }

        private void hexBox_TextChanged( object sender, EventArgs e )
        {

        }

        private void decBox_TextChanged( object sender, EventArgs e )
        {

        }

        // Updates boxes with correct conversions
        private void updateBoxes( int po2 )
        {
            UInt64 dec = po2ToDec( po2 );
            updatePo2( po2 );
            updateShorthand( po2 );
            updateHex( dec );
            updateDec( dec );
        }
        // UInt64 overload
        private void updateBoxes( UInt64 dec )
        {

        }

        private void updatePo2( int po2 )
        {
            po2Box.Text = Convert.ToString( po2 );
        }

        private void updateShorthand( int po2 )
        {
            shorthandBox.Text = Convert.ToString( po2ToShorthandNumeral( po2 ) );
            shortHandComboBox.SelectedIndex = po2ToShorthandPrefix( po2 );
        }

        private void updateHex( UInt64 dec )
        {
            hexBox.Text = decToHex( dec );
        }

        private void updateDec( UInt64 dec )
        {
            decBox.Text = Convert.ToString( dec );
        }

        // Various Conversions

        private UInt64 po2ToDec( int po2 )
        {
            return Convert.ToUInt64( Math.Pow( 2, po2 ) );
        }

        private int po2ToShorthandNumeral( int po2 )
        {
            return (int) Math.Pow( 2, po2 % 10 );
        }

        // Converts into ComboBox index
        private int po2ToShorthandPrefix( int po2 )
        {
            return (po2 - ( po2 % 10 )) / 10;
        }

        private string decToHex( UInt64 dec )
        {
            return String.Concat( "0x", dec.ToString( "X" ) );
        }

        // Unused
        private void MainForm_Load( object sender, EventArgs e )
        {

        }

        private void label1_Click( object sender, EventArgs e )
        {

        }
    }
}
