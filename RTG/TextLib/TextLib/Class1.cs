using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TextLib
{
    public class Words
    {
        Random r = new Random();

        string[] subs = new string[] { "Я", "Мы", "Он", "Она", "Они" };
        string[] preds_of_1 = new string[] { " собираюсь", " хочу", " буду" };
        string[] preds_of_2 = new string[] { " собираемся", " хотим", " будем" };
        string[] preds_of_3 = new string[] { " собирается", " хочет", " будет" };
        string[] preds_of_4 = new string[] { " собираются", " хотят", " будут" };
        string[] preds2 = new string[] { " учиться", " сидеть", " бегать" };
        string[] places = new string[] { " в колледже", " в парке", " в ТЦ" };
        string[] days = new string[] { " сегодня", " завтра", " когда-нибудь" };
        string[] time = new string[] { " в 5 утра", " вечером", " после обеда" };

        public string GetSent()
		{
            int ran = r.Next(0, 5);
            string sent = subs[ran];

            if (ran == 0)
                sent += preds_of_1[r.Next(0, 3)];
            else if (ran == 1)
                sent += preds_of_2[r.Next(0, 3)];
            else if ((ran == 2) || (ran == 3))
                sent += preds_of_3[r.Next(0, 3)];
            else if (ran == 4)
                sent += preds_of_4[r.Next(0, 3)];

            sent += preds2[r.Next(0, 3)] + places[r.Next(0, 3)] + days[r.Next(0, 3)] +
                time[r.Next(0, 3)];

            return sent;

        }
    }
}
