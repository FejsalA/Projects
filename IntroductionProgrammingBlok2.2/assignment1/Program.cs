using System;

namespace assignment1
{
    class Program
    {
        static void Main(string[] args)
        {
            if (args.Length != 2)
            {
                Console.WriteLine("invalid number of arguments!");
                Console.WriteLine("usage: assignment[1-3] <nrOfRows> <nrOfColums>");
                return;
            }

            int nrOfRows = int.Parse(args[0]);
            int nrOfColumns = int.Parse(args[1]);

            Program myProgram = new Program();
            myProgram.Start(nrOfRows, nrOfColumns);

        }

        void Start(int nrOfRows, int nrOfCollumns)
        {
            int[,] matrix = new int[nrOfRows, nrOfCollumns];


           // InitMatrix2D(matrix);
            InitMatrixLinear(matrix);
           
            DisplayMatrixWithCross(matrix);

            Console.ReadKey();
        }

        void InitMatrix2D(int[,] matrix)
        {
            int n = 1;

            for (int nrOfRows = 0; nrOfRows < matrix.GetLength(0); nrOfRows++)
            {

                for (int nrOfColumns = 0; nrOfColumns < matrix.GetLength(1); nrOfColumns++)
                {
                    matrix[nrOfRows, nrOfColumns] = n;
                    n++;

                }
            }
         
        }
        
        void DisplayMatrix(int[,] matrix)
        {
            for (int nrOfRows = 0; nrOfRows < matrix.GetLength(0); nrOfRows++)
            {


                for (int nrOfColumns= 0; nrOfColumns < matrix.GetLength(1); nrOfColumns++)
                {

                    Console.Write("{0, 4}",matrix[nrOfRows, nrOfColumns]);

                }
                Console.WriteLine();



            }
        }

        void InitMatrixLinear(int[,] matrix)
        {

            for (int i = 0; i < matrix.GetLength(0) * matrix.GetLength(1); i++)
            {
                int row = i / matrix.GetLength(1);
                int column = i % matrix.GetLength(1);

                matrix[row, column] = (i + 1);
            }
        }

        void DisplayMatrixWithCross(int[,] matrix)
        {
            int i = 0;
            int j = 0;

            for (int nrOfRows = 0; nrOfRows < matrix.GetLength(0); nrOfRows++)
            {
                for (int nrOfColumns = 0; nrOfColumns < matrix.GetLength(1); nrOfColumns++)
                {
                    if (nrOfRows == nrOfColumns && (matrix[nrOfRows, nrOfColumns] + nrOfRows) % matrix.GetLength(0) == 0)
                    {
                        Console.ForegroundColor = ConsoleColor.Red;
                        Console.BackgroundColor = ConsoleColor.Yellow;
                    }
                    else if(nrOfRows == nrOfColumns)
                    {
                        Console.ForegroundColor = ConsoleColor.Red;
                    }
                    else if((matrix[nrOfRows, nrOfColumns] +nrOfRows) % matrix.GetLength(0) == 0 ) 
                    {
                        Console.BackgroundColor = ConsoleColor.Yellow;
                    }
                    else
                    {
                        Console.ResetColor();
                    }

                    Console.Write("{0, 4}", matrix[nrOfRows, nrOfColumns]);
                    i--;
                    j++;
                }
                Console.WriteLine();
            }
        }

    }
}
