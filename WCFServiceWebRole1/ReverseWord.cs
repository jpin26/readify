using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Web;

namespace WCFServiceWebRole1
{
    public static class ReverseWord
    {
        public static string Reverse(string word)
        {
            if (word == null)
            {
                throw new ArgumentNullException("s", "Value cannot be null.");
            }

            StringBuilder sb = new StringBuilder();
            var letters = word.ToCharArray();

            for (var i = letters.Length; i >= 0; i--)
            {
                sb.Append(letters[i].ToString());
            }

            return sb.ToString();
        }
    }
}