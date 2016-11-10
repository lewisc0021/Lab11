using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lab11
{
    public class Staff : Person
    {
        #region VARIABLES
        private string school;
        private double pay;
        #endregion

        #region CONSTRUCTOR
        public Staff (string name, string address, string school, double pay) : base(name, address)
        {
            SCHOOL = school;
            PAY = pay;
        }
        #endregion

        #region PROPERTIES
        public string SCHOOL
        {
            get
            {
                return school;
            }

            set
            {
                school = value;
            }
        }

        public double PAY
        {
            get
            {
                return pay;
            }

            set
            {
                pay = value;
            }
        }
        #endregion

        public override string ToString()
        {
            return ($"Staff[{base.ToString()},school={SCHOOL},pay={PAY}]");
        }


    } }//END----------------
