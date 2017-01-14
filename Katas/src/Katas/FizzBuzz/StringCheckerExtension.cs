namespace Katas.FizzBuzz
{
    public static class StringCheckerExtension
    {
        public static bool IsFizz(this int i)
        {
            return i % 3 == 0;
        }

        public static bool IsBuzz(this int i)
        {
            return i % 5 == 0;
        }
    }
}
