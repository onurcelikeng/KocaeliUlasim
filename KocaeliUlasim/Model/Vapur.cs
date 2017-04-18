using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace KocaeliUlasim.Model
{
    public class Vapur
    {

        public string[] getVapurList()
        {
            string[] array = { "İzmit", "Gölcük", "Değirmendere", "Karamürsel", "Hereke", "Derince", "Tütünçiftlik", "Yarımca" };

            return array;
        }

        public string getId(string value)
        {
            string index = "0";

            if (value == "İzmit") index = "1";
            if (value == "Gölcük") index = "2";
            if (value == "Değirmendere") index = "3";
            if (value == "Karamürsel") index = "5";
            if (value == "Hereke") index = "7";
            if (value == "Derince") index = "8";
            if (value == "Tütünçiftlik") index = "9";
            if (value == "Yarımca") index = "10";

            return index;
        }

    }
}
