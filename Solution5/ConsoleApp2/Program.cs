﻿// Разработать тип для работы с матрицами
//Реализовать операции, позволяющие выполнять операции сложения, вычитания и умножения матриц,
//предусмотрев возможность их выполнения, в противном случае должно генерироваться пользовательское
//исключение.
//Сохранить значение матрицы в файл (сериализация) и восстановить из файла.


namespace ConsoleApp2
{
    class Program
    {
        static void Main()
        {
            string path =
                "/Users/vrublevskyi.o/RiderProjects/Gratyky_1.1/Gratyky_1.1/Solution5/ConsoleApp2/content.txt";


            Matrix matrixA = new Matrix("hfvidj");
            Matrix matrixB = new Matrix();
            Matrix matrixC = new Matrix();
            //matrixA.GetMatrixFromConsole("matrixA");
            //matrixB.GetMatrixFromConsole("matrixB");
            matrixA.PrintMatrix();
            matrixB.PrintMatrix();

            //matrixC.Add(matrixA);
            
            matrixC = matrixA.Add(matrixB);

       
            

            //File.WriteAllText(path, originalText);
            File.AppendAllText(path, "\nHello work");
            
            string fileText = File.ReadAllText(path);
            Console.WriteLine(fileText);
        }
    }
}