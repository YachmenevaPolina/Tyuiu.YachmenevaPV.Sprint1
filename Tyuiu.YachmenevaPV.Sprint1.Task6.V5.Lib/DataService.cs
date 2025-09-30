using tyuiu.cources.programming.interfaces.Sprint1;
namespace Tyuiu.YachmenevaPV.Sprint1.Task6.V5.Lib
{
    public class DataService : ISprint1Task6V5
    {
        public string CheckSymmetricalWords(string value)
        {
            string[] words = value.Split(' ', StringSplitOptions.RemoveEmptyEntries);
            string result = "";
            foreach (string word in words)
            {
                string reversed = new string(word.Reverse().ToArray());
                if (word == reversed)
                {
                    if (result.Length > 0) result += " ";
                    result += word;
                    
                }
            }
            return result;
        }
    }
}
