using System;

namespace QualificationSimulator
{
    class Program
    {
        static void Main(string[] args)
        {
            //Input
            string nab = Console.ReadLine();
            string s = Console.ReadLine();
            string[] arynab = nab.Split(" ");

            int a = int.Parse(arynab[1]);
            int b = int.Parse(arynab[2]);         
            int judgeAplusB = a + b;
            int passCount = 0;
            int internationalOrder = 0;

            bool judge = false;

            foreach(var item in s)
            {
                //cのその他は無条件で脱落
                if (item.ToString() == "c") judge = false;
               
     
                if (item.ToString() == "a")
                {
                    judge = passCount < judgeAplusB ? true : false;
                    if (judge) passCount++;
                }

                if (item.ToString() == "b")
                {    
                    if ((passCount < judgeAplusB) && (internationalOrder < b)) {
                        judge = true;
                        passCount++;
                        internationalOrder++;
                    }
                    else
                    {
                        judge = false;
                    }
                }               

                //Output Result
                if (judge)
                {
                    Console.WriteLine("Yes");
                }
                else
                {
                    Console.WriteLine("No");
                }
            }
        }
    }
}
