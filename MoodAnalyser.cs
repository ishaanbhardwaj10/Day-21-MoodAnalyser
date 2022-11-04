using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MoodAnalyserExceptionProblem
{
    public class MoodAnalyser
    {
        private string message;

        public MoodAnalyser()
        {
            this.message = null;
        }

        public MoodAnalyser(string message)
        {
            this.message = message;
        }

        public string analyseMood()
        {
            try
            {
                if(this.message == null)
                {
                    throw new MoodAnalysisException(MoodAnalysisException.ExceptionType.NULL_MESSAGE, "Message is NULL");
                }
                if(this.message.Equals(string.Empty))
                {
                    throw new MoodAnalysisException(MoodAnalysisException.ExceptionType.EMPTY_MESSAGE, "Message is Empty");
                }
                if (this.message.Contains("Sad"))
                {
                    return "SAD";
                }
                else
                {
                    return "HAPPY";
                }
            }
            catch(MoodAnalysisException ex)
            {
                Console.WriteLine(ex.Message);
                if (ex.type == MoodAnalysisException.ExceptionType.EMPTY_MESSAGE)
                    return "";
                else
                    return null;
            }
            catch (NullReferenceException ex)
            {
                Console.WriteLine(ex.Message);
                return "HAPPY";
            }
            catch (Exception ex)
            {
                Console.WriteLine(ex.Message);
                return null;
            }
        }

    }


}
