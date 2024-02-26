using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace _1_add_binary
{
    public class Solution
    {
        public String AddBinary(String a, String b)
    {
        String s = "";
        int lengthA = a.Length - 1;
        int lengthB = b.Length - 1;
        int temp = 0;

        while(lengthA >= 0 || lengthB >= 0 || temp == 1) {
            if(lengthA >= 0) {
                temp += a[lengthA--] - '0';
            } 
            if (lengthB >= 0) {
                temp += b[lengthB--] - '0';
            }
            s = (temp % 2) + s;
            temp /= 2;
        }
        return s;
    }
    }
}