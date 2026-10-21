public class SpiralMatrix
{
    public static int[,] GetMatrix(int size)
    {
        int[,] result = new int[size, size];

        int endNum = size * size;
        int current = 0;

        int row = 0;
        int col = 0;

        int bottom = size - 1;
        int right = size - 1;
        int top = 0;
        int left = 0;

        while (current < endNum)
        {
            current++;
            result[row, col] = current;

            if ((row == top && col < right))
            {
                col++;
                if (col == right) top++;
            }
            else if (col == right && row < bottom)
            {
                row++;
                if (row == bottom) right--;
            }
            else if (row == bottom && col > left)
            {
                col--;
                if (col == left) bottom--;
            }
            else if (col == left && row > top)
            {
                row--;
                if (row == top) left++;
            }
        }
        PrintMatrix(result);
        return result;
    }

    public static void PrintMatrix(int[,] matrix)
    {
        for (int i = 0; i < matrix.GetLength(0); i++)
        {
            for (int j = 0; j < matrix.GetLength(1); j++)
            {
                Console.Write(matrix[i, j] + " ");
            }
            Console.WriteLine();
        }
    }
}