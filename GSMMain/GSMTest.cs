using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GSMMain
{
    public class GSMTest
    {

        public void GSMList()
        {
            List<GSM> gsms = new List<GSM>();

            for (int i = 0; i < 50; i++)
            {
                gsms.Add(new GSM("model " + i, "Nokia"));
            }
            foreach (var gsm in gsms)
            {
                Console.WriteLine(gsm);
            }
            Console.WriteLine(GSM.IPhone4S);
        }
    }
}


