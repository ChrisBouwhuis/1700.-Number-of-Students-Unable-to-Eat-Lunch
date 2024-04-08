using Classlib;

namespace _1700._Number_of_Students_Unable_to_Eat_Lunch
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Solution solution = new Solution();
            int[] students = { 1, 1, 1, 0, 0, 1 };
            int[] sandwiches = { 1, 0, 0, 0, 1, 1 };
            int result = solution.CountStudents(students, sandwiches);
            Console.WriteLine(result);
        }
    }
}
