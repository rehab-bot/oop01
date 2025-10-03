using System.ComponentModel.Design;

namespace oop01
{
    internal class Program
    {
        static void Main(string[] args)
        {


            #region EX01
            //Console.WriteLine("days of week ");
            //foreach (WeekDays day in Enum.GetValues(typeof(WeekDays)))
            //{
            //    Console.WriteLine(day);
            //} 
            #endregion

            #region EX02

            //Seas_on temp;
            //bool isparsed;
            //do
            //{
            //    Console.WriteLine("Enter the Season :");
            //    isparsed = Enum.TryParse<Seas_on>(Console.ReadLine(), true, out temp);
            //} while (!isparsed);
            //if (temp == Seas_on.Spring)
            //{
            //    Console.WriteLine("Spring March to May");
            //}
            //else if (temp == Seas_on.Summer)
            //    Console.WriteLine("Summer June to August");
            //else if (temp == Seas_on.Autumn)
            //    Console.WriteLine("Autumn September to November");
            //else if (temp == Seas_on.Winter)
            //    Console.WriteLine("Winter December to February");
            #endregion
            #region EX03
            User u1 = new User();
            u1.permissions ^= Permission.read;

            if ((u1.permissions & Permission.read) == Permission.read)
                Console.WriteLine("equal");
            else
                Console.WriteLine("not equal");
            #endregion
            #region EX04
            //Colors temp;
            // bool isparsed;
            // do
            // {
            //     Console.WriteLine("Enter the color :");
            //     isparsed = Enum.TryParse<Colors>(Console.ReadLine(), out temp);

            // }while(!isparsed);
            // if(temp == Colors.red || temp == Colors.green|| temp == Colors.blue)
            //     Console.WriteLine("primary color");
            // else
            //     Console.WriteLine("not primary color"); 
            #endregion
        }
    }
}


