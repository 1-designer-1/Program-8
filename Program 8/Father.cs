using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Program_8
{
    class Father : Ihuman
    {
        private string _name;
        public string Name { get => _name; set => _name = value; }
        public string Print()
        {
            return "Имя отца: " + Name;
        }

    }

    class Children : Father
    {
        private string _name;
        private string _middleName;

        public new string Name { get => _name; set => _name = value; }

        public string MiddleName { get => _middleName; set => _middleName = value; }

        public new string Print()
        {
            return "Имя ребенка: " + Name + " Отчество " + MiddleName;
        }


    }











}
