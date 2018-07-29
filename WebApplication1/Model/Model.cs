using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace WebApplication1.ModelList
{
    public class ModelList
    {
        string x;
        string y;
        public string X { get => x; set => x = value; }
        public string Y { get => y; set => y = value; }
        public ModelList(string x_o, string y_o)
        {
            x = x_o;
            y = y_o;
        }
        public ModelList(){


            }
    }
}