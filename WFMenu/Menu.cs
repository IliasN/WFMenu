using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WFMenu
{
    class Menu
    {
        #region Fields

        private const double BEEF_PRICE = 12.8;
        private const double SPAG_PRICE = 7.8;
        private const double TRUITE_PRICE = 10.55;
        private const double DESSERT_PRICE = 2.4;

        private int _nbBeef;
        private int _nbSpag;
        private int _nbTruite;
        private int _nbDessert;
        private double _total;
        #endregion

        #region

        public int NbBeef
        {
            get
            {
                return _nbBeef;
            }

            set
            {
                _nbBeef = value;
            }
        }

        public int NbSpag
        {
            get
            {
                return _nbSpag;
            }

            set
            {
                _nbSpag = value;
            }
        }

        public int NbTruite
        {
            get
            {
                return _nbTruite;
            }

            set
            {
                _nbTruite = value;
            }
        }

        public int NbDessert
        {
            get
            {
                return _nbDessert;
            }

            set
            {
                _nbDessert = value;
            }
        }

        public double Total
        {
            get
            {
                return _total;
            }

            set
            {
                _total = value;
            }
        }

        #endregion

        #region

        #region
        #endregion

        #endregion
    }
}
