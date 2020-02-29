using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using GuineaPig.Models;

namespace GuineaPigData
{
    public class GuineaPigHandler
    {

        public static GuineaPigInfo getInfo()
        {
            GuineaPigInfo startdata = new GuineaPigInfo();
            startdata.breeds = new List<string> { "Teddy", "Absynnian", "Peruvian", "American", "Other" };

            return startdata;
        }
    }
}
