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
        public MainForm()
        {
            InitializeComponent();
        }

        // Text update functions
        private void po2Box_TextChanged( object sender, EventArgs e )
        {
            try
            {
                int power = Convert.ToInt32( po2Box.Text );
                if( power < 64 )
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
                // Tried to enter something that's not an integer
                po2Box.Clear();
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
            updatePo2( po2 );
            updateShorthand( po2 );
            updateHex( po2 );
            updateDec( po2 );
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

        private void updateHex( int po2 )
        {
            hexBox.Text = po2ToHex( po2 );
        }

        private void updateDec( int po2 )
        {
            decBox.Text = Convert.ToString( po2ToDec( po2 ) );
        }

        // Various Conversions

        private int po2ToShorthandNumeral( int po2 )
        {
            return (int) Math.Pow( 2, po2 % 10 );
        }

        // Converts into ComboBox index
        private int po2ToShorthandPrefix( int po2 )
        {
            return (po2 - ( po2 % 10 )) / 10;
        }

        private string po2ToHex( int po2 )
        {
            UInt64 intValue = po2ToDec( po2 );
            return String.Concat( "0x", intValue.ToString( "X" ) );
        }

        private UInt64 po2ToDec( int po2 )
        {
            return Convert.ToUInt64( Math.Pow( 2, po2 ) );
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
