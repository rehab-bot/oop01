namespace oop01
{
    internal class Program
    {
        static void Main(string[] args)
        {
            #region EX01

            Console.WriteLine("Days of week ");
            foreach (WeekDays day in Enum.GetValues(typeof(WeekDays)))
            {
                Console.WriteLine(day);
            }
            #endregion
        }
    }
}
