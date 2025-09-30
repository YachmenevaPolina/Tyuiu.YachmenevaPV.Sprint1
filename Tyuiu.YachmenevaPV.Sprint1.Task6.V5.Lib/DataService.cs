using tyuiu.cources.programming.interfaces.Sprint1;
namespace Tyuiu.YachmenevaPV.Sprint1.Task6.V5.Lib
{
    public class DataService : ISprint1Task6V5
    {
        public string CheckSymmetricalWords(string value)
        {
            string reversed = new string(value.Reverse().ToArray());
            if (value == reversed)
                return value;
            return "";
        }
    }
}
