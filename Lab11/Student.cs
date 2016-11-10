using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lab11
{
    public class Student : Person
    {
        #region VARIABLES
        private string program;
        private int year;
        private double fee;
        #endregion

        #region CONSTRUCTOR
        public Student(string name, string address,string program,int year, double fee) : base (name, address)
        {
            PROGRAM = program;
            YEAR = year;
            FEE = fee;

        }
        #endregion

        #region PROPERTIES  
        public string PROGRAM
        {
            get
            {
                return program;
            }

            set
            {
                program = value;
            }
        }

        public int YEAR
        {
            get
            {
                return year;
            }

            set
            {
                year = value;
            }
        }

        public double FEE
        {
            get
            {
                return fee;
            }

            set
            {
                fee = value;
            }
        }
        #endregion

        public override string ToString()
        {
            return ($"Student[{base.ToString()},program={PROGRAM},year={YEAR},fee={FEE}]");
        }


    } }//END------------------
