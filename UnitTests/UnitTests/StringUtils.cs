using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace UnitTests
{
    public class StringUtils
    {
        public string ReverseString(string value)
        {
            return value.Reverse().ToString();
        }

        public string ReverseStringWithFor(string value)
        {
            if (value == null)
            {
                throw new ArgumentNullException();
            }

            StringBuilder s = new StringBuilder();

            for (int i = value.Length - 1; i >= 0; i--)
            {
                s.Append(value[i]);
            }

            return s.ToString();
        }
    }
}
