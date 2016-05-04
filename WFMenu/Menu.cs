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

        #region Properties

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

        #region Methodes

        #region Constructor

        public Menu()
        {
            this.NbBeef = 0;
            this.NbDessert = 0;
            this.NbSpag = 0;
            this.NbTruite = 0;
            this.Total = 0;
        }

        #endregion

        public void AddBeef()
        {
            this.NbBeef++;
            this.Total += BEEF_PRICE;
        }

        public void AddSpag()
        {
            this.NbSpag++;
            this.Total += SPAG_PRICE;
        }

        public void AddTruite()
        {
            this.NbTruite++;
            this.Total += TRUITE_PRICE;
        }

        public void AddDessert()
        {
            this.NbDessert++;
            this.Total += DESSERT_PRICE;
        }

        public override string ToString()
        {
            string ret = this.NbBeef.ToString() + " : Roti de boeuf à " + BEEF_PRICE.ToString() + Environment.NewLine;
            ret += this.NbSpag.ToString() + " : Spaghettis à la bolognaise à " + SPAG_PRICE.ToString() + Environment.NewLine;
            ret += this.NbTruite.ToString() + " : Truite aux amendes à " + TRUITE_PRICE.ToString() + Environment.NewLine;
            ret += this.NbDessert.ToString() + " : Dessert à " + DESSERT_PRICE.ToString() + Environment.NewLine;
            ret += "Votre total à payer est de : " + Total.ToString() + " Frs" + Environment.NewLine;
            ret += "*****************************************************************";
            return ret;
        }

        #endregion
    }
}
