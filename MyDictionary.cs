using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApplication_Dictionary
{
    class MyDictionary
    {
        private Dictionary<int, string> dictionary;

        public MyDictionary()
        {
            this.dictionary = new Dictionary<int, string>();
            populateDictionary();
        }

        private void populateDictionary()
        {
            // populate the ditionary with 11,998,949 records
            for (int i = 0; i < 11998949; i++) 
            {
                this.dictionary.Add(i, "value-"+i.ToString());
            }
        }

        public Dictionary<int, string> getDictionary()
        {
            return this.dictionary;
        }
    }
}
