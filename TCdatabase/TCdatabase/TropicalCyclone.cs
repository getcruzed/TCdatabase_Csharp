using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TCdatabase
{
    class TropicalCyclone
    {
        /// <summary>
        /// (Enum) Basin where TC occured.
        /// </summary>
        private enum basin
        {
            Atlantic,
            NE_Pacific,
            NW_Pacific,
            N_Indian,
            SW_Indian,
            SE_Indian,
            SW_Pacific
        }

        /// <summary>
        /// ATCF cyclone number for that year
        /// </summary>
        private string ATCFNumber;

        /// <summary>
        /// Year
        /// </summary>
        private int year;

        /// <summary>
        /// TC name
        /// </summary>
        private string name;

        /// <summary>
        /// Number of best track entries
        /// </summary>
        private int numberOfEntries;




    }
}
