namespace ConsoleApp2;

public class Matrix
{
    public double[,] Array { get; set; }
    //public double[,] MatrixB { get; set; }
    //public double[,] MatrixC { get; set; }

    public Matrix()
    {
            
    }
    
    public Matrix(string name)
    {
        Console.Write("Rows: {0}: ", name);
        var n = int.Parse(Console.ReadLine());
        Console.Write("Columns: {0}: ", name);
        var m = int.Parse(Console.ReadLine());

        var matrix = new double[n, m];
        for (var i = 0; i < n; i++)
        {
            for (var j = 0; j < m; j++)
            {
                Console.Write("{0}[{1},{2}] = ", name, i, j);
                matrix[i, j] = int.Parse(Console.ReadLine());
            }
        }
        Array = matrix;
    }
    
    public void PrintMatrix()
    {
        for (var i = 0; i < Array.GetLength(0); i++)
        {
            for (var j = 0; j < Array.GetLength(1); j++)
            {
                Console.Write(Array[i, j].ToString().PadLeft(4));
            }
            Console.WriteLine();
        }
    }


    public Matrix Add(Matrix matrixB)
    {
        if (this.Array.GetLength(1) == matrixB.Array.GetLength(0))
        {
            throw new Exception("Expected different dimensions of matrix");
        }

        var matrixC = new double[this.Array.GetLength(0), matrixB.Array.GetLength(1)];

        for (var i = 0; i < this.Array.GetLength(0); i++)
        {
            for (var j = 0; j < matrixB.Array.GetLength(1); j++)
            {
                matrixC[i, j] = this.Array[i, j] + matrixB.Array[i, j];
            }
        }

        return matrixC;
    }


    public double[,] Multiplication(double[,] matrixA, double[,] matrixB)
    {       
        if (matrixA.GetLength(1) != matrixB.GetLength(0))
        {
            throw new Exception("Expected different dimensions of matrix");
        }

        var matrixC = new double[matrixA.GetLength(0), matrixB.GetLength(1)];

        for (var i = 0; i < matrixA.GetLength(0); i++)
        {
            for (var j = 0; j < matrixB.GetLength(1); j++)
            {
                matrixC[i, j] = 0;

                for (var k = 0; k < matrixA.GetLength(1); k++)
                {
                    matrixC[i, j] += matrixA[i, k] * matrixB[k, j];
                }
            }
        }

        return matrixC;
    }
    
    
    public double[,] Subtraction(double[,] matrixA, double[,] matrixB)
    {
        if (matrixA.GetLength(1) == matrixB.GetLength(0))
        {
            throw new Exception("Expected different dimensions of matrix");
        }

        var matrixC = new double[matrixA.GetLength(0), matrixB.GetLength(1)];

        for (var i = 0; i < matrixA.GetLength(0); i++)
        {
            for (var j = 0; j < matrixB.GetLength(1); j++)
            {
                matrixC[i, j] = matrixA[i, j] - matrixB[i, j];
            }
        }
        return matrixC;
    }
}