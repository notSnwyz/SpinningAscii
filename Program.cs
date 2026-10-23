// Program.cs

class Program
{
    static void Main(string[] args)
    {
        int width = 40;
        int height = 20;

        char[,] buffer = new char[height, width];

        for (int row = 0; row < height; row++)
        {
            for (int column = 0; column < width; column++)
            {
                buffer[row, column] = ' ';
            }
        }

        buffer[10, 20] = '#';

        for (int row = 0; row < height; row++)
        {
            for (int column = 0; column < width; column++)
            {
                Console.Write(buffer[row, column]);
            }
            Console.WriteLine();
        }
    }
}