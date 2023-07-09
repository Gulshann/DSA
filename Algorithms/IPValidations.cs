using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace DSA.Algorithms
{
    
    public class IPValidations
    {
        IList<string> result = new List<string>();
        int count = 0;

        public IPValidations()
        {
            RestoreIpAddresses("25525511135");
        }

        public IList<string> RestoreIpAddresses(string s)
        {
            int len = s.Length;
            if (len > 12 || len<4) return result;

            Rec(s[0].ToString(), s, 1, 3);

            return new List<string>();
        }

        private void Rec(string ip, string s, int index, int dot)
        {
            var part = ip.Split('.').ToList();
            if (part.Count > 4) return;
            foreach(var item in part)
            {
                int val = int.Parse(item);
                if (item.Length > 3 || val>255)
                    return;
            }
            count++;


            if (dot < 0)
            {
                return;
            }

            if (index < s.Length)
            {
                Rec(ip + s[index].ToString(), s, index + 1, dot);
                Rec(ip + "." + s[index].ToString(), s, index + 1, dot - 1);
            }
            else
            {
                if (isValidIP(ip))
                {
                    result.Add(ip);
                }
                else
                {
                    return;
                }
            }
        }

        private bool isValidIP(string ip)
        {
            var part = ip.Split('.');
            if (part.Length == 4)
            {
                bool isValid = true;

                foreach(var item in part)
                {
                    int val = int.Parse(item);

                    if(val>255 ||(item[0]=='0' && item.Length != 1))
                    {
                        return false;
                        
                    }
                }
                return true;
            }
            return false;
        }
    }
}
