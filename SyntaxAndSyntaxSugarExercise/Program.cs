namespace SyntaxAndSyntaxSugarExercise
{
    public class Program
    {
        static void Main(string[] args)
        {
            Sugar();
            
        }

        static void Sugar()
        {
            
            var answer = 27;
            var answer2 = 29;
           // if (answer < answer2)
            //{ 
                //response = $"{answer} is less than {answer2}";
            //}
           // else
            //{
                //response = $"{answer} is greater than or equal to {answer2} ";
                
                
            //}

              var response = answer < answer2
                ? $"{answer} is less than {answer2}"
                : $"{answer} is greater than {answer2}";
            Console.WriteLine(response);
        }
    }
}
