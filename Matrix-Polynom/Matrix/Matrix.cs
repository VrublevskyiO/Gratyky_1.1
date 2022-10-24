using System;
using System.Runtime.Serialization;
using System.Runtime.Serialization.Formatters.Binary;
using Serilog;
namespace Matrix;

[Serializable]
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
        res = arr_1.Subtract(arr_2);
        return res;
    }
    
    public static Matrix operator * (Matrix arr_1, Matrix arr_2)
    {
        Matrix res = new Matrix();
        res = arr_1.Multiply(arr_2);
        return res;
    }
    
    public void GetMatrixFromConsole(string name)
    {
        try
        {
            Log.Information("Method GetMatrixFromConsole was started");
            
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
            Log.Information(" GetMatrixFromConsole was successfully finished");
        }
        catch (System.ArrayTypeMismatchException ex)
        {
            Console.WriteLine("Catch error with element type. \nMore inf: {0}",ex);
            Log.Debug("Catch error with element type");
            Log.Error("Program was unsuccessfully finished");
            throw;
        }
    }
    
    public void GetMatrixFromFile(string path)
    {
        try
        {
            Log.Information("Method GetMatrixFromFile was started");
            
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
           
            Log.Information("GetMatrixFromFile was successfully finished");
        }
        catch (System.IndexOutOfRangeException ex)
        {
            Console.WriteLine("Catch error, massive has extra element(s). \nMore inf: {0}",ex);
            Log.Debug("Catch error, massive has extra element(s)");
            Log.Error("Program was unsuccessfully finished");
            throw;
        }
    }

    public void PrintMatrix()
    {
        Log.Information("Method PrintMatrix was started");
        
        for (var i = 0; i < InternalMatrix.GetLength(0); i++)
        {
            for (var j = 0; j < InternalMatrix.GetLength(1); j++)
            {
                Console.Write("{0} ",InternalMatrix[i, j]);
            }
            Console.WriteLine(" ");
        }
        Console.WriteLine(" ");
        
        Log.Information("PrintMatrix was successfully finished");
    }
    
    public void SaveMatrix(string path)
    {
        Log.Information("Method SaveMatrix was started");
        
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
        
        Log.Information("SaveMatrix was successfully finished");
    }
    


    public Matrix Add(Matrix extraArray)
    {
        Log.Information("Method Add was started");
        
        if (this.Row != extraArray.Row)
        {
            Log.Error("Expected different dimensions of matrix");
            Log.Error("Program was unsuccessfully finished");
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

        Log.Information("Add was successfully finished");
        
        return res;
    }
    
    public Matrix Subtract(Matrix extraArray)
    {
        Log.Information("Method Subtract was started");
        
        if (this.Row != extraArray.Row)
            {
                Log.Error("Expected different dimensions of matrix");
                Log.Error("Program was unsuccessfully finished");
                throw new Exception("Expected different dimensions of matrix");
            }

            Matrix res = new Matrix(Row, extraArray.Row);

            for (var i = 0; i < InternalMatrix.GetLength(0); i++)
            {
                for (var j = 0; j < extraArray.Column; j++)
                {
                    res[i, j] = InternalMatrix[i, j] - extraArray[i, j];
                }
            }
            Log.Information("Subtract was successfully finished");
            
            return res;
    }


    public Matrix Multiply(Matrix extraArray)
    {
        try
        {
            Log.Information("Method Multiply was started");
            
            if (this.Row != extraArray.Column || this.Column != extraArray.Row)
            {                
                Log.Error("Expected different dimensions of matrix");
                Log.Error("Program was unsuccessfully finished");
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
            Log.Information("Multiply was successfully finished");
            
            return res;
        }
        
        catch (System.ArithmeticException ex)
        {
            Console.WriteLine("Catch errors with arithmetic operations. \nMore inf: {0}",ex);
            Log.Debug("Catch errors with arithmetic operations");
            Log.Error("Program was unsuccessfully finished");
            throw;
        }

    }
    
    public void SaveSerializedMatrix(string path)
    {
        Log.Information("Method SaveSerializedMatrix was started");
        
        Console.WriteLine("Saved serialized matrix:");

        IFormatter formatter = new BinaryFormatter();
        using (Stream stream = new FileStream(path, FileMode.Create))
        {
            formatter.Serialize(stream, InternalMatrix);
        }
        
        Log.Information("SaveSerializedMatrix was successfully finished");
    }

    public void OpenSerializedMatrix(string path)
    {
        Log.Information("Method OpenSerializedMatrix was started");
        
        IFormatter formatter = new BinaryFormatter();
        using (Stream stream = new FileStream(path, FileMode.Open))
        {
            double[,] dp = (double[,])formatter.Deserialize(stream);
            for (var i = 0; i < dp.GetLength(0); i++)
            {
                for (var j = 0; j < dp.GetLength(1); j++)
                {
                    Console.Write("{0} ", dp[i, j]);
                }

                Console.WriteLine(" ");
            }

            Console.WriteLine(" ");
        }
        
        Log.Information("OpenSerializedMatrix was successfully finished");
    }
}