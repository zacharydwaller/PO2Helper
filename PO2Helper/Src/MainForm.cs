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

        // Converter
        public PO2Helper.MyConverter converter;

        // MainForm Constructor
        public MainForm()
        {
            InitializeComponent();
            converter = new MyConverter();
        }

        // MainForm Startup
        private void MainForm_Load( object sender, EventArgs e )
        {
            
            updateBoxesPo2( 0 );
        }

        // Text update functions
        private void po2Box_TextChanged( object sender, EventArgs e )
        {
            int power;
            po2Box.SelectionStart = po2Box.Text.Length;
            if( tryParseBox( po2Box, out power ) )
            {
                if( power < maxPo2 )
                {
                    updateBoxesPo2( power );
                }
                else
                {
                    pushOverflowError( po2Box );
                }
            }
        }

        private void shorthandNumBox_SelectedIndexChanged( object sender, EventArgs e )
        {
            shorthand_changed();
        }

        private void shorthandPrefBox_SelectedIndexChanged( object sender, EventArgs e )
        {
            shorthand_changed();
        }

        private void shorthand_changed()
        {
            int po2 = converter.shorthandToPo2( shorthandNumBox.SelectedIndex, shorthandPrefBox.SelectedIndex );
            if( po2 < maxPo2 )
            {
                updateBoxesPo2( po2 );
            }
            else
            {
                updateBoxesPo2( maxPo2 - 1 );
            }
        }

        private void hexBox_TextChanged( object sender, EventArgs e )
        {
            string hex;
            hexBox.SelectionStart = hexBox.Text.Length;
            if( tryParseBoxHex( hexBox, out hex ) )
            {
                updateBoxesDec( converter.hexToDec( hex ) );
            }
        }

        private void decBox_TextChanged( object sender, EventArgs e )
        {
            UInt64 dec;
            decBox.SelectionStart = decBox.Text.Length;
            if( tryParseBoxULong( decBox, out dec ) )
            {
                updateBoxesDec( dec );
            }
        }

        // Updates boxes with correct conversions
        private void updateBoxesPo2( int po2 )
        {
            UInt64 dec = converter.po2ToDec( po2 );
            updatePo2( po2 );
            updateShorthand( po2 );
            updateHex( dec );
            updateDec( dec );
        }
        // UInt64 overload
        private void updateBoxesDec( UInt64 dec )
        {
            int po2 = converter.decToPo2( dec );
            updatePo2( po2 );
            updateShorthand( po2 );
            updateHex( dec );
            updateDec( dec );
        }

        private void updatePo2( int po2 )
        {
            po2Box.Text = Convert.ToString( po2 );
        }

        private void updateShorthand( int po2 )
        {
            shorthandNumBox.SelectedIndex = converter.po2ToShorthandNumeral( po2 );
            shorthandPrefBox.SelectedIndex = converter.po2ToShorthandPrefix( po2 );
        }

        private void updateHex( UInt64 dec )
        {
            hexBox.Text = converter.decToHex( dec );
        }

        private void updateDec( UInt64 dec )
        {
            decBox.Text = Convert.ToString( dec );
        }

        

        // Try to parse input as numerals
        private bool tryParseBoxULong( TextBox box, out UInt64 value )
        {
            try
            {
                value = Convert.ToUInt64( box.Text );

                return true;
            }
            catch( OverflowException overflow )
            {
                pushOverflowError( box );
            }
            catch
            {
                box.SelectAll();
            }
            value = 0;
            return false;
        }

        private bool tryParseBoxHex( TextBox box, out string value )
        {
            UInt64 dec;
            value = box.Text;

            if( value.StartsWith( "0x", StringComparison.OrdinalIgnoreCase ) )
            {
                value = value.Substring(2);
            }
            else if(value.Equals("Overflow"))
            {
                return false;
            }

            try
            {
                // Try conversion
                dec = Convert.ToUInt64( value, 16 );

                if(converter.decToPo2(dec) < maxPo2)
                {
                    
                    return true;
                }
                else
                {
                    throw new OverflowException();
                }
            }
            catch( OverflowException )
            {
                pushOverflowError( box );
                return false;
            }
            catch( FormatException )
            {
                char[] buffer = new char[64];
                box.Text.CopyTo(0, buffer, 0, box.Text.Length - 1);
                box.Text = new String( buffer );
            }
            catch
            {
                box.SelectAll();
            }

            value = String.Empty;
            return false;
        }

        private bool tryParseBox( TextBox box, out int value )
        {
            UInt64 output;
            bool success = tryParseBoxULong( box, out output );
            value = Convert.ToInt32( output );
            return success;
        }
        
        private void pushOverflowError( TextBox box )
        {
            box.Clear();
            box.Text = "Overflow";
            box.SelectAll();
        }
        
    }
}
