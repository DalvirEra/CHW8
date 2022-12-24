int[,] array1 = arraygen();
int[,] array2 = arraygen();
int[,] matrix = MatrixMultiplication(array1,array2);
Array2DPrint(matrix);

void Array2DPrint(int[,] matrix){
    for (int i = 0; i<matrix.GetLength(0); i++){
        for (int j = 0; j < matrix.GetLength(1); j++){
            Console.Write(matrix[i,j] + " ");
        }
        Console.WriteLine();
    }
}

int[,] MatrixMultiplication(int[,] array1,int[,] array2){
    Console.WriteLine("Итоговая матрица: ");
    int[,] matrix = new int[array1.GetLength(0),array1.GetLength(1)];
    if (array1.GetLength(1) == array2.GetLength(0)){
        for (int x = 0; x< array1.GetLength(0); x++){
            for (int y = 0; y < array2.GetLength(1);y++){
                for (int var = 0; var < array1.GetLength(1);var++){
                    matrix[x,y] += array1[x,var]*array2[var,y];
                }
            }  
        }
        return matrix;
    }
    else{
        Console.WriteLine("Не умножаемые матрицы, возвращаю пустую матрицу.");
        return matrix;
    }
}

int[,] arraygen(){
    Console.WriteLine("Введите два числа размера массива:");
    Console.Write("x: ");
    int x = Convert.ToInt32(Console.ReadLine());
    Console.Write("y: ");
    int y = Convert.ToInt32(Console.ReadLine());
    Console.WriteLine("Генерация массива...");
    int[,] array = new int[x,y];
    for (int i = 0; i<x; i++){
        for (int j = 0; j < y; j++){
            array[i,j] = new Random().Next(1,10);
            Console.Write(array[i,j] + " ");
        }
        Console.WriteLine();
    }
    Console.WriteLine("=======");
    return array;
}