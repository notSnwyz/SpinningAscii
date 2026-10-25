// Program.cs

class Program
{
    static void DrawLine(char[,] buffer, int row1, int col1, int row2, int col2)
    {
        int rowDistance = row2 - row1;
        int colDistance = col2 - col1;
        int steps = Math.Max(Math.Abs(rowDistance), Math.Abs(colDistance));

        if (steps == 0)
        {
            buffer[row1, col1] = '#';
            return;
        }

        double rowStep = (double)rowDistance / steps;
        double colStep = (double)colDistance / steps;

        for (int i = 0; i <= steps; i++)
        {
            int row = (int)Math.Round(row1 + i * rowStep);
            int col = (int)Math.Round(col1 + i * colStep);
            buffer[row, col] = '#';
        }
    }

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

        int[,] edges =
        {
            { 0, 1 },
            { 2, 3 },
            { 4, 5 },
            { 6, 7 },

            { 0, 2 },
            { 1, 3 },
            { 4, 6 },
            { 5, 7 },

            { 0, 4 },
            { 1, 5 },
            { 2, 6 },
            { 3, 7 }
        };

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

        DrawLine(buffer, 15, 30, 2, 5);

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