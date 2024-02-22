namespace csharp_d1
{
    class Program
    {
        
            static void Mymethod()
            {
                Console.WriteLine("my name is najim and i am a developer");
            }


            static void Main(string[] args)
            {
                Mymethod();
            }

        string[] cars = { "bmw", "audi", "mastang", "swift" };

        for (int i = 0; i<cars.length; i++)
        {
            console.writeline(cars[i]);
        }

    int[,] num = { { 1, 2, 3 }, { 4, 5, 6 } };

        foreach (int i in num)
        {
            console.writeline(i);
        }

int[,] num3 = { { 1, 2, 3 }, { 4, 5, 6 } };

for (int i = 0; i < num3.getlength(0); i++)
{
    for (int j = 0; j < num3.getlength(1); j++)
    {
        console.writeline(num3[i, j]);
    }
}


    }
}