namespace Robber_Assignment
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Enter No of robbers: ");
            int n = int.Parse(Console.ReadLine());

            Console.WriteLine("Enter the robber with whon sam will start shooting: ");
            int Start = int.Parse(Console.ReadLine());

            Console.WriteLine("Enter the gap between robbers: ");
            int gap = int.Parse(Console.ReadLine());

            int[] arr = new int[n];
            int CurrentIndex = Start - 1;
            int ShotsCompleted = 0;

            for (int i = 0; i < n; i++)
            {
                arr[i] = i + 1;
                //Console.WriteLine(robbers[i]);
            }


            while (n != 0)
            {
                if (CurrentIndex >= n)
                {
                    CurrentIndex = CurrentIndex % n;
                }

                Console.WriteLine($"Target = {arr[CurrentIndex]} , {++ShotsCompleted} shots completed");

                //removing the curentelement
                for (int i = CurrentIndex; i < n - 1; i++)
                {
                    arr[i] = arr[i + 1];
                }
                n--;
                CurrentIndex += gap;
            }



            Console.WriteLine(ShotsCompleted + " shots taken");
        }
    }
}