using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ListApp
{
    
        public class MontsOfYear
        {
            private string [] _iteams = 
            new string[] { "Januar","February","March","April","May","June","July","August","September","October","November","December" };
            public int this[string key]
            {
                get { return GetIndexOfMont(key); }
                
            }
            private int GetIndexOfMont(string key)
            {
                int defaultmont = 0;
                for (int i = 0; i < _iteams.Length; i++)
                {
                    if (_iteams[i]==key)
                    {
                        defaultmont = i;
                    }

                }
                defaultmont++;
                return defaultmont;

            }
        }
    
}
