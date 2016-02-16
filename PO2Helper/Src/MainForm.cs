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
            int power;
            if( tryParseBox( po2Box, out power ) )
            {
                if( power < maxPo2 )
                {
                    updateBoxesPo2( power );
                }
                else
                {
                    po2Box.Clear();
                }
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
        private void updateBoxesPo2( int po2 )
        {
            UInt64 dec = po2ToDec( po2 );
            updatePo2( po2 );
            updateShorthand( po2 );
            updateHex( dec );
            updateDec( dec );
        }
        // UInt64 overload
        private void updateBoxesDec( UInt64 dec )
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
            // Returns ComboBox index
            return Convert.ToInt32( Math.Pow( 2, po2 % 10 ) );
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

        // Try to parse input as numerals
        private bool tryParseBoxULong( TextBox box, out UInt64 value )
        {
            try
            {
                value = Convert.ToUInt64( box.Text );

                return true;
            }
            catch
            {
                po2Box.SelectAll();
                value = 0;
                return false;
            }
        }
        private bool tryParseBox( TextBox box, out int value )
        {
            UInt64 output;
            bool success = tryParseBoxULong( box, out output );
            value = Convert.ToInt32( output );
            return success;
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
