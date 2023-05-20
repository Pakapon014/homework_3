using System;

class Program
{
    static void Main()
    {
        bool continueProgram = true;

        while (continueProgram)
        {
            Console.WriteLine("Enter '+' or '-' to perform matrix addition or subtraction.");
            Console.WriteLine("Enter any other character to exit.");

            char operation = Console.ReadKey().KeyChar;
            Console.WriteLine();

            if (operation == '+' || operation == '-')
            {
                Console.Write("Enter the size of the matrix: ");
                int size = int.Parse(Console.ReadLine());

                Console.WriteLine("Enter the elements of the matrix:");
                double[,] matrix = new double[size, size];

                for (int i = 0; i < size; i++)
                {
                    for (int j = 0; j < size; j++)
                    {
                        matrix[i, j] = double.Parse(Console.ReadLine());
                    }
                }

                Console.WriteLine("Result:");

                if (operation == '+')
                {
                    PrintMatrix(AddMatrix(matrix, size));
                }
                else if (operation == '-')
                {
                    PrintMatrix(SubtractMatrix(matrix, size));
                }
            }
            else
            {
                continueProgram = false;
            }
        }
    }

    static double[,] AddMatrix(double[,] matrix, int size)
    {
        double[,] result = new double[size, size];

        for (int i = 0; i < size; i++)
        {
            for (int j = 0; j < size; j++)
            {
                result[i, j] = matrix[i, j] + matrix[j, i];
            }
        }

        return result;
    }

    static double[,] SubtractMatrix(double[,] matrix, int size)
    {
        double[,] result = new double[size, size];

        for (int i = 0; i < size; i++)
        {
            for (int j = 0; j < size; j++)
            {
                result[i, j] = matrix[i, j] - matrix[j, i];
            }
        }

        return result;
    }

    static void PrintMatrix(double[,] matrix)
    {
        int size = matrix.GetLength(0);

        for (int i = 0; i < size; i++)
        {
            for (int j = 0; j < size; j++)
            {
                Console.Write(matrix[i, j] + " ");
            }

            Console.WriteLine();
        }
    }
}
