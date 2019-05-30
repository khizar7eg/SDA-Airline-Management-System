using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace commerced
{
    class Expenses
    {
        
        private string EXpensetype;
        private string  DATE;
        private string AMOUNT;

       
        public string noocakharash
        {
            get { return EXpensetype; }
            set { EXpensetype = value; }
        }
        public string datekakharashlagalay
        {
            get { return DATE; }
            set { DATE = value; }
        }
        public string xadigakharashka
        {
            get { return AMOUNT; }
            set { AMOUNT = value; }
        }

    }
}
