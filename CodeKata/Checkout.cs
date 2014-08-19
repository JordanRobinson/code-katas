using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CodeKata
{
    using System.Diagnostics;

    internal class Checkout
    {

        public int total;

        private string items = "";

        public void Scan(char code)
        {
            items += code;
            var itemsArray = items.ToCharArray();
            Array.Sort(itemsArray);
            items = new string(itemsArray);


            if (items.Contains("AAA"))
            {
                items = items.Replace("AAA", "Z");
                total -= 100;
                code = 'Z';
            }
            else if (items.Contains("BB"))
            {
                items = items.Replace("BB", "Y");
                total -= 30;
                code = 'Y';
            }

            switch (code)
            {
                case 'A':
                    total += 50;
                    break;
                case 'B':
                    total += 30;
                    break;
                case 'C':
                    total += 20;
                    break;
                case 'D':
                    total += 15;
                    break;
                case 'Y':
                    total += 45;
                    break;
                case 'Z':
                    total += 130;
                    break;
                default:
                    Debug.WriteLine("It done broke");
                    break;
            }
        }
    }
}
