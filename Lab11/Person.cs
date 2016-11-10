using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lab11
{
    public class Person
    {
        #region VARIABLES 
        private string name;
        private string address;
        #endregion

        #region CONSTRUCTOR
        public Person(string name, string address)
        {
            this.name = name;
            ADDRESS = address;
        }
        #endregion

        #region PROPERTIES 
        public string NAME
        {
            get
            {
                return name;
            }

        }

        public string ADDRESS
        {
            get
            {
                return address;
            }

            set
            {
                address = value;
            }
        }
        #endregion

        public override string ToString()
        {
            return ($"Person[name={NAME},address={ADDRESS}]");
        }





    } }//END----------------
