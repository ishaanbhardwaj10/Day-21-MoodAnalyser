namespace MoodAnalyserExceptionProblem
{
    class Program
    {
        public static void Main(string[] args)
        {

            MoodAnalyser moodAnalyser = new MoodAnalyser();
            string myMood = moodAnalyser.analyseMood();
            Console.WriteLine(myMood);

        }
    }
}