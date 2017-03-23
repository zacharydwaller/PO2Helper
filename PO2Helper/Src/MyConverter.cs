using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace PO2Helper
{
    public class MyConverter
    {

        // Various Conversions

        public UInt64 po2ToDec( int po2 )
        {
            return Convert.ToUInt64( Math.Pow( 2, po2 ) );
        }

        // Returns ComboBox index - the '2' in 2K
        public int po2ToShorthandNumeral( int po2 )
        {
            return po2 % 10;
        }

        // Returns ComboBox index - the 'K' in 2K
        public int po2ToShorthandPrefix( int po2 )
        {
            return ( po2 - ( po2 % 10 ) ) / 10;
        }

        public int shorthandToPo2( int numeral, int prefix )
        {
            return ( prefix * 10 ) + numeral;
        }

        // Rounds up to the nearest power of 2
        public int decToPo2( UInt64 dec )
        {
            int po2 = 0;
            while( dec > Math.Pow( 2, po2 ) )
            {
                po2++;
            }
            return po2;
        }

        public string decToHex( UInt64 dec )
        {
            return String.Concat( "0x", dec.ToString( "X" ) );
        }

        // Assumes hex is valid
        public UInt64 hexToDec( string hex )
        {
            return Convert.ToUInt64( hex, 16 );
        }
    }
}
