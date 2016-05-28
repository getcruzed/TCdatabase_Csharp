using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TCdatabase
{
    public class FileHandlerAndParser
    {

        public void parseStormsToDatabase( 
            ref TropicalCycloneDatabase database,
            string[] fileText,
            ref string errorMessages )
        {

            int numberOfLines = fileText.Length;
            int linePosition = 0;
            while( linePosition < numberOfLines)
            {

                TropicalCyclone temp = new TropicalCyclone();

                /// Grab header line for storm.
                /// Basin_Number_Year, Name, number of records
                string[] line = fileText[linePosition].Split(',');

                // Check basin
                string basinTemp = line[0] + line[1];
                

            }
        }


        private TropicalCyclone.basin getBasinID( string s )
        {
            switch( s )
            {
                case "AL":
                    return TropicalCyclone.basin.Atlantic;
                default:
                    return TropicalCyclone.basin.Unavailable;
            }
        }
    }
}
