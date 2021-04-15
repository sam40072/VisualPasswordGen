using System;
using System.Collections.Generic;

namespace Password_Gen
{
    class quack
    {
        public static string randomstring(int a, bool ASCII)
        {
            string basestring = "abcdefghijklmnopqrstuvwxyz123456789";
            string basestringASCII = "abcdefghijklmnopqrstuvwxyz123456789.<!@;:#$%^&*()_+-={}[]æ«§ª•¢¹ඞ▌╧░│";
            string randomstring = "";
            Random r = new Random();
            List<string> charlist = new List<string>();
            if (ASCII == false)
            {
                foreach (char f in basestring)
                {
                    charlist.Add(f.ToString());
                }
                for (int i = 0; i < a; i++)
                {
                    randomstring = randomstring + charlist[r.Next(basestring.Length)];
                }
            }
            else
            {
                foreach (char f in basestringASCII)
                {
                    charlist.Add(f.ToString());
                }
                for (int i = 0; i < a; i++)
                {
                    randomstring = randomstring + charlist[r.Next(basestringASCII.Length)];
                }
            }


            return randomstring;

        }
        public static int randomint(int min, int max)
        {
            Random r = new Random();
            return r.Next(min, max);
        }
    }
}
