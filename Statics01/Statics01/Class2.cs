using System;
using System.Collections.Generic;
using System.Text;

namespace Statics01{
        static class Class2
        {
            public static string ToFormattedString(this int[] a)
            {
                string s = "{";
                for (int i = 0; i < a.Length; i++)
                {
                    s += a[i];
                    if (i < a.Length - 1)
                        s += ",";
                }
                s += "}";
                return s;
            }
        }
}
