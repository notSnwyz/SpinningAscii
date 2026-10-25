// Program.cs

class Program
{
    static void Main(string[] args)
    {
        int width = 40;
        int height = 20;

        Point3D[] corners = new Point3D[8];
        corners[0] = new Point3D(-1, -1, -1);
        corners[1] = new Point3D(1, -1, -1);
        corners[2] = new Point3D(-1, 1, -1);
        corners[3] = new Point3D(1, 1, -1);
        corners[4] = new Point3D(-1, -1, 1);
        corners[5] = new Point3D(1, -1, 1);
        corners[6] = new Point3D(-1, 1, 1);
        corners[7] = new Point3D(1, 1, 1);

        char[,] buffer = new char[height, width];

        for (int row = 0; row < height; row++)
        {
            for (int column = 0; column < width; column++)
            {
                buffer[row, column] = ' ';
            }
        }

        for (int i = 0; i < corners.Length; i++)
        {
            int column = (int)Math.Round(width / 2 + corners[i].X * 8);
            int row = (int)Math.Round(height / 2 + -corners[i].Y * 4);

            buffer[row, column] = '#';
        }

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