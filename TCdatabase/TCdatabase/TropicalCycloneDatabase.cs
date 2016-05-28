using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TCdatabase
{
    class TropicalCycloneDatabase
    {

        /// <summary>
        /// Database of all Tropical Cyclones in HURDAT
        /// </summary>
        List<TropicalCyclone> AllStorms = new List<TropicalCyclone>();

        /// <summary>
        /// Database of all Tropical Cylones that underwent RI.
        /// </summary>
        List<TropicalCyclone> RIStorms = new List<TropicalCyclone>();


        public TropicalCycloneDatabase()
        {
            
        }

        /// <summary>
        /// Adds a storm to the database.
        /// </summary>
        /// <param name="tc"></param>
        public void addStormToDatabase( TropicalCyclone tc )
        {
            AllStorms.Add(tc);
        }

        public void addRIStormToDatabase( TropicalCyclone tc )
        {
            RIStorms.Add(tc);
        }


    }
}
