using LuckyTicket.Interfaces;
using System;

namespace LuckyTicket
{
    public class Ticket: ITicket
    {
        static bool ISValide(int min, int max, string str)
        {
            if (str.Length < min || str.Length > max 
                || str==null || str.Length<2) return false;
            else return true;
        }
        public bool LuckyTest(int min, int max, string str)
        {
            try
            {
                Convert.ToInt64(str);
            }
            catch { };

            if (!ISValide(min, max, str))
            {
                return false;
            }
            else
            {
                int leftPart = 0;
                int rightPart = 0;
                int i = 1;

                if (str.Length%2 != 0) { str = "0" + str; }
                foreach(var st in str)
                {
                    if (i <= str.Length / 2) leftPart += Convert.ToInt32(st);
                    else rightPart += Convert.ToInt32(st);
                    i++;
                }
                if (leftPart == rightPart) return true;
                else return false;
            }
        }
    }
}
