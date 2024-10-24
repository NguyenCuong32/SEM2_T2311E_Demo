internal class Program
{
    private static void Main(string[] args)
    {
        float salary = CalculateSalary(1000, 200);
        System.Console.WriteLine("Your salary " + salary);
        // ExampleLoopFor();
        // ExampleLoopWhile();
        ExampleLoopForeach();

    }
    /// <summary>
    /// Hàm tính tổng lương
    /// </summary>
    /// <param name="basic"></param>
    /// <param name="bonus"></param>
    /// <returns></returns>
    private static float CalculateSalary(float basic, float bonus)
    {
        return basic + bonus;
    }
    private static void ExampleLoopFor()
    {
        for (int i = 0; i < 10; i=i+3)
        {
            System.Console.WriteLine(string.Format("Number i {0}", i));
        }
    }
    private static void ExampleLoopWhile()
    {
        int j = 0;
        while (j < 10)
        {
            if (j % 2 == 0)
            {
                System.Console.WriteLine("Even");
            }
            else
            {
                System.Console.WriteLine("Old");
            }
            System.Console.WriteLine(string.Format("Number j {0}", j));
            j++;
        }
    }
    private static void ExampleLoopForeach()
    {
        int[] array = [0, 1, 1.1, 56, 7];
        foreach (var item in array)
        {
            System.Console.WriteLine(string.Format("Item {0}", item));
        }
    }

}