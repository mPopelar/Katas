namespace Katas.FizzBuzz
{
    public class Printer
    {
        public string PrintNumbersFromOneToHundred()
        {
            var number = string.Empty;
            for (var i = 1; i < 100; i++)
            {
                string append = GetAppend(i);

                number += append;
            }

            return number.Trim();
        }

        private static string GetAppend(int i)
        {
            var append = string.Empty;

            if (i.IsFizz())
            {
                append = "Fizz";
            }
            else if (i.IsBuzz())
            {
                append = "Buzz";
            }
            else
            {
                append = " " + i;
            }

            return append;
        }
    }
}
