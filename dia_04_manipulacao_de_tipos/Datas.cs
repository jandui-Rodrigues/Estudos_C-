namespace TDate
{
    public class Date
    {

        // Date.Day
        // Date.Month
        // Date.Year
        // Date.Hour
        // Date.Minute
        // Date.Second 
        
        public static void Util()
        {
            var date = new DateTime(2020, 12, 31, 10, 30, 0);
            // Console.WriteLine(date.ToString("dd-MM-yyyy HH:mm:ss"));
            Console.WriteLine(date.ToString());

        }

        public static void Now()
        {
            var dataType = DateTime.Now;
            Console.WriteLine(dataType.ToString());
        }

        public static void OnlyDate()
        {
            var date = new DateTime(2022, 03, 09, 10, 30, 0);
            var dateOnly = date.Date;
            Console.WriteLine(dateOnly.ToString());
        }
    }
}