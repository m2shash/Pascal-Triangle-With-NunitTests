
using System;
public class PascalAssignment
{
    public static void Main()
    {
        int no_row, c = 1, blk, i, j;

        Console.Write("\n\n");
        Console.Write("Display the Pascal's triangle:\n");
        Console.Write("--------------------------------");
        Console.Write("\n\n");

        Console.Write("Input number of rows: ");

        no_row = Convert.ToInt32(Console.ReadLine());
        for (i = 0; i < no_row; i++)
        {
            for (blk = 1; blk <= no_row - i; blk++)
                Console.Write("  ");
            for (j = 0; j <= i; j++)
            {
                if (j == 0 || i == 0)
                    c = 1;
                else
                    c = c * (i - j + 1) / j;
                Console.Write("{0}   ", c);
            }
            Console.Write("\n");
            
        }

        Console.WriteLine(pascal(0, 2));
        Console.WriteLine(pascal(1, 2));
        Console.WriteLine(pascal(1, 3));
        Console.WriteLine(pascal(2, 3));
        Console.WriteLine("output for pascal(3 col , 4 row): {0} ", pascal(3,4));
        Console.WriteLine("output for pascal(2 col , 4 row): {0} ", pascal(2, 4));
        Console.WriteLine("output for pascal(4 col , 5 row): {0} ", pascal(4, 5 ));
        Console.WriteLine("output for pascal(3 col , 6 row): {0} ", pascal(3, 6));
        Console.ReadLine();


    }

    public static int pascal(int col, int row)
    {
        if (row == 0)
            return 1;

        if (col == 0 || col == row)
            return 1;

        return pascal(col - 1, row - 1) + pascal(col, row - 1);       
    }
}