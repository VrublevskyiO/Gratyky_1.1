// Разработать тип для работы с матрицами
//Реализовать операции, позволяющие выполнять операции сложения, вычитания и умножения матриц,
//предусмотрев возможность их выполнения, в противном случае должно генерироваться пользовательское
//исключение.
//Сохранить значение матрицы в файл (сериализация) и восстановить из файла.

namespace Matrix;
class Program
{
    static void Main()
    {
        string path_1 = "/Users/vrublevskyi.o/RiderProjects/Gratyky_1.1/Gratyky_1.1/Matrix-Polynom/Matrix/matrix_1.txt";
        string path_2 = "/Users/vrublevskyi.o/RiderProjects/Gratyky_1.1/Gratyky_1.1/Matrix-Polynom/Matrix/matrix_2.txt";
        string path_3 = "/Users/vrublevskyi.o/RiderProjects/Gratyky_1.1/Gratyky_1.1/Matrix-Polynom/Matrix/res_matrix.txt";
        
        Matrix matrixA = new Matrix(); 
        Matrix matrixB = new Matrix();
        //matrixA.GetMatrixFromConsole("matrixA");
        //matrixA.PrintMatrix();
        
        //matrixB.GetMatrixFromConsole("matrixA");
        //matrixB.PrintMatrix();
        
        matrixA.GetMatrixFromFile(path_1);
        matrixB.GetMatrixFromFile(path_2);

        var res = matrixA + matrixB;
        res.PrintMatrix();
        
        res = matrixA - matrixB;
        res.PrintMatrix();
        
        res = matrixA * matrixB;
        res.PrintMatrix();
        
        res.SaveMatrix(path_3);

        //File.WriteAllText(path, originalText);
        //File.AppendAllText(path_3,res.ToString());
        
        
        
        string fileText = File.ReadAllText(path_3);
        Console.WriteLine(fileText);
        
        Console.ReadLine();
    }
}
