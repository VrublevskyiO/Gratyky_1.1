namespace Matrix;

public class Matrix
{
    private double[,] InternalMatrix { get; set; }

    public int Row { get; set; }
    public int Column { get; set; }

    public Matrix() { }

    public Matrix(int rows, int columns)
    {
        Row = rows;
        Column = columns;
        this.InternalMatrix = new double[rows, columns];
    }
    

    public double this[int row, int column]
    {
        get { return InternalMatrix[row, column]; }
        set { InternalMatrix[row, column] = value; }
    }

    public static Matrix operator + (Matrix arr_1, Matrix arr_2)
    {
        Matrix res = new Matrix();
        res = arr_1.Add(arr_2);
        return res;
    }
    
    public static Matrix operator - (Matrix arr_1, Matrix arr_2)
    {
        Matrix res = new Matrix();
        res = arr_1.Subtraction(arr_2);
        return res;
    }
    
    public static Matrix operator * (Matrix arr_1, Matrix arr_2)
    {
        Matrix res = new Matrix();
        res = arr_1.Multiplication(arr_2);
        return res;
    }
    
    public void GetMatrixFromConsole(string name)
    {

        Console.Write("Rows: {0}: ", name);
        var row = int.Parse(Console.ReadLine());
        Console.Write("Columns: {0}: ", name);
        var column = int.Parse(Console.ReadLine());

        Row = row;
        Column = column;
        //var matrix = new double[n, m];
        InternalMatrix = new double[row, column];
        for (var i = 0; i < row; i++)
        {
            for (var j = 0; j < column; j++)
            {
                Console.Write("{0}[{1},{2}] = ", name, i, j);
                InternalMatrix[i, j] = int.Parse(Console.ReadLine());
            }
        }
    }
    
    public void GetMatrixFromFile(string path)
    {
        var input = File.ReadAllText(path);
        Column = Int32.Parse(input.Substring(0, input.IndexOf(' ')));
        Row = Int32.Parse(input.Substring(input.IndexOf(' '), input.IndexOf('\n')));
        InternalMatrix = new double[Row, Column];
        
        int i = 0, j = 0, k = 0;
        foreach (var row in input.Split('\n'))
        {
            j = 0;
            if (k == 0)
            {
                k++; 
                continue; 
            }
            foreach (var col in row.Trim().Split(' '))
            {
                InternalMatrix[i, j] = int.Parse(col.Trim());
                j++;
            }
            i++;
        }
    }

    public void PrintMatrix()
    {
        for (var i = 0; i < InternalMatrix.GetLength(0); i++)
        {
            for (var j = 0; j < InternalMatrix.GetLength(1); j++)
            {
                Console.Write("{0} ",InternalMatrix[i, j]);
            }
            Console.WriteLine(" ");
        }
        Console.WriteLine(" ");
    }
    
    public void SaveMatrix(string path)
    {
        Console.WriteLine("Saved matrix:");
        for (var i = 0; i < InternalMatrix.GetLength(0); i++)
        {
            for (var j = 0; j < InternalMatrix.GetLength(1); j++)
            {
                File.AppendAllText(path,InternalMatrix[i, j].ToString());
                File.AppendAllText(path, " ");
            }
            File.AppendAllText(path, " \n");
        }
        File.AppendAllText(path, " \n");
    }
    


    public Matrix Add(Matrix extraArray)
    {
        if (this.Row != extraArray.Row)
        {
            throw new Exception("Expected different dimensions of matrix");
        }

        Matrix res = new Matrix(this.InternalMatrix.GetLength(0), extraArray.Row);

        for (var i = 0; i < InternalMatrix.GetLength(0); i++)
        {
            for (var j = 0; j < extraArray.Column; j++)
            {
                res[i, j] = InternalMatrix[i, j] + extraArray[i, j];
            }
        }

        return res;
    }
    
    public Matrix Subtraction(Matrix extraArray)
    {
        if (this.Row != extraArray.Row)
        {
            throw new Exception("Expected different dimensions of matrix");
        }

        Matrix res = new Matrix(this.InternalMatrix.GetLength(0), extraArray.Row);

        for (var i = 0; i < InternalMatrix.GetLength(0); i++)
        {
            for (var j = 0; j < extraArray.Column; j++)
            {
                res[i, j] = InternalMatrix[i, j] - extraArray[i, j];
            }
        }

        return res;
    }


    public Matrix Multiplication(Matrix extraArray)
    {
        if (this.Row != extraArray.Column || this.Column != extraArray.Row)
        {
            throw new Exception("Expected different dimensions of matrix");
        }

        Matrix res = new Matrix(InternalMatrix.GetLength(0), extraArray.Row);

        for (var i = 0; i < InternalMatrix.GetLength(0); i++)
        {
            for (var j = 0; j < extraArray.Row; j++)
            {
                res[i, j] = 0;

                for (var k = 0; k < InternalMatrix.GetLength(1); k++)
                {
                    res[i, j] += InternalMatrix[i, k] * extraArray[k, j];
                }
            }
        }
        return res;
    }
}