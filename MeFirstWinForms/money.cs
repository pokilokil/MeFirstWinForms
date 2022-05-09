using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MeFirstWinForms
{
    public class money
    {
        public long rub;
        public int kop;
        public money(long irub, int ikop)
        {
            rub = irub;
            kop = ikop;
        }
        public money()
        {

        }
        public static money PlusST(money mon1, money mon2)
        {
            long origr = mon1.rub;
            int origkop = mon1.kop;
            long vhrub = mon2.rub;
            int vhkop = mon2.kop;

            long resrub = origr + vhrub;
            int resk = origkop + vhkop;
            if (resk > 100)
            {
                resrub = resrub + 1;
                resk = resk - 100;
            }
            money ress = new money(resrub, resk);

            ress.rub = resrub;
            ress.kop = resk;

            return ress;
        }
        public static money UmnozhST(money inc, money m1)
        {
            long origr = m1.rub;
            int origkop = m1.kop;

            long vhrub = inc.rub;
            int vhkop = inc.kop;
            //входящее в виде Double
            double firstD = (double)vhrub + (double)vhkop / 100.0;
            //оригинальное (первое)
            double sec = (double)origr + (double)origkop / 100.0;

            double res = firstD * sec;
            long tselayaChast = (long)Math.Floor(res);
            double drobn = res - tselayaChast;
            money ress = new money();
            double kopp = Math.Round(drobn * 100);
            int kopInt = (int)kopp;

            ress.rub = tselayaChast;
            ress.kop = kopInt;
            return ress;
        }
        public money Plus(money inc)
        {
            long origr = rub;
            int origkop = kop;
            long vhrub = inc.rub;
            int vhkop = inc.kop;

            long resrub = rub + vhrub;
            int resk = kop + vhkop;
            if (resk > 100)
            {
                resrub = resrub + 1;
                resk = resk - 100;
            }
            money ress = new money(resrub, resk);

            ress.rub = resrub;
            ress.kop = resk;

            return ress;
        }

        public money Minus(money inc)
        {
            long origr = rub;
            int origkop = kop;
            long vhrub = inc.rub;
            int vhkop = inc.kop;
            // 9.09 - 8.99
            long resrub = rub - vhrub;
            int resk = kop - vhkop;
            if (resk < 0)
            {
                resrub = resrub - 1;
                resk = (-1) * resk;
            }
            money ress = new money();

            ress.rub = resrub;
            ress.kop = resk;
            return ress;
        }

        public money Umnozh(money inc)
        {
            long origr = rub;
            int origkop = kop;

            long vhrub = inc.rub;
            int vhkop = inc.kop;
            //входящее в виде Double
            double firstD = (double)vhrub + (double)vhkop / 100.0;
            //оригинальное (первое)
            double sec = (double)origr + (double)origkop / 100.0;

            double res = firstD * sec;
            long tselayaChast = (long)Math.Floor(res);
            double drobn = res - tselayaChast;
            money ress = new money();
            double kopp = Math.Round(drobn * 100);
            int kopInt = (int)kopp;

            ress.rub = tselayaChast;
            ress.kop = kopInt;
            return ress;
        }
        public money Delenie(money inc)
        {
            long origr = rub;
            int origkop = kop;

            long vhrub = inc.rub;
            int vhkop = inc.kop;

            double second = (double)vhrub + (double)vhkop / 100.0;
            double first = (double)origr + (double)origkop / 100.0;
            if (second == 0)
            {
                throw new FormatException("делене на 0");
            }
            double third = first / second;

            long tselayaChast = (long)Math.Floor(third);
            double drobn = third - tselayaChast;
            money ress = new money();
            double kopp = Math.Round(drobn * 100);
            int kopInt = (int)kopp;

            ress.rub = tselayaChast;
            ress.kop = kopInt;
            return ress;

        }
        public static money DelenieST(money m1, money m2)
        {
            long origr = m1.rub;
            int origkop = m1.kop;

            long vhrub = m2.rub;
            int vhkop = m2.kop;


            double first = (double)origr + (double)origkop / 100.0;
            double second = (double)vhrub + (double)vhkop / 100.0;
            if (second == 0)
            {
                throw new FormatException("делене на 0");
            }
            double third = first / second;

            long tselayaChast = (long)Math.Floor(third);
            double drobn = third - tselayaChast;
            money ress = new money();
            double kopp = Math.Round(drobn * 100);
            int kopInt = (int)kopp;

            ress.rub = tselayaChast;
            ress.kop = kopInt;
            return ress;

        }
    }
}
