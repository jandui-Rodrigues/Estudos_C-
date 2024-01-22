// “d”	6/15/2008
// “D”	Sunday, June 15, 2008
// “f”	Sunday, June 15, 2008 9:15 PM
// “F”	Sunday, June 15, 2008 9:15:07 PM
// “g”	6/15/2008 9:15 PM
// “G”	6/15/2008 9:15:07 PM
// “m”	June 15
// “o”	2008-06-15T21:15:07.0000000
// “R”	Sun, 15 Jun 2008 21:15:07 GMT
// “s”	2008-06-15T21:15:07
// “t”	9:15 PM
// “T”	9:15:07 PM
// “u”	2008-06-15 21:15:07Z
// “U”	Monday, June 16, 2008 4:15:07 AM
// “y”	June, 2008

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
            // ToString Converte o valor do DateTime para um string 
            Console.WriteLine(date.ToString("D"));

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
    public class FuncDate
    {
        // o day e obrigatorio, mas o month e year sao opcionais
        // .AddYears(int value): Adiciona uma quantidade de anos a uma data.
        // .AddMonths(int value): Adiciona uma quantidade de meses a uma data.
        // .AddDays(double value): Adiciona uma quantidade de dias a uma data.
        // .AddHours(double value): Adiciona uma quantidade de horas a uma data.
        // .AddMinutes(double value): Adiciona uma quantidade de minutos a uma data.
        // .AddSeconds(double value): Adiciona uma quantidade de segundos a uma data.
        // .AddMilliseconds(double value): Adiciona uma quantidade de milissegundos a uma data.
        public static void SomeToday(int days = 0, int month = 0, int year = 0 )
        {
            var today = DateTime.Now;
            // var duration = new TimeSpan(36, 0, 0, 0);
            var answer = today.AddDays(days);
            answer = answer.AddMonths(month);
            answer = answer.AddYears(year);

            Console.WriteLine("Hoje é " +today.Day +"/" +today.Month +" - " +today.DayOfWeek);
            Console.WriteLine("Daqui a 36 dias será "+answer.Day +"/" +answer.Month +" - " +answer.DayOfWeek);
        }

        public static void CompareDates()
        {
            var T1 = new DateTime(2020, 12, 31, 10, 30, 0);
            var T2 = new DateTime(2020, 12, 31, 10,29, 0);

            int result = DateTime.Compare(T1, T2); // -1 antes, 0 igual , 1 depoes

            switch(result)
            {
                case -1:
                    Console.WriteLine("T1 é anterior a T2");
                    break;
                case 0:
                    Console.WriteLine("T1 é igual a T2");
                    break;
                case 1:
                    Console.WriteLine("T1 é posterior a T2");
                    break;
            }
        }
    }
}