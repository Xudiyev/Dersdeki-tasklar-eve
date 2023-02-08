using System;
using System.Collections.Generic;
using System.Text;

namespace _08._02._2023
{
    class Student: Human
    {

        public string GroupNo;

        public override int Age
        {
            get
            {
                return _age;
            }

            set
            {
                if (value >= 15 && value <= 65)
                    _age = value;
            }
        }
    }
}
