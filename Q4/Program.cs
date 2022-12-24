int[,] array = arrayGenNonRepitable();
Array2DPrint(array);
// вот и попилили программу на функции =)

int[,] arrayGenNonRepitable(){
    Console.WriteLine("Введите два числа размера массива:");
    Console.Write("x: ");
    int x = Convert.ToInt32(Console.ReadLine());
    Console.Write("y: ");
    int y = Convert.ToInt32(Console.ReadLine());
    int[,] array = new int[x,y];
    if (x*y <= 89){
        Console.WriteLine("Генерация массива...");
        int number;
        for (int i = 0; i<x; i++){
            for (int j = 0; j < y; j++){
                while (array[i,j] == 0){
                    number = new Random().Next(10,89);
                    if (!arrayContains(array,number)){
                        array[i,j] = number;
                    }
                }
                Console.Write(array[i,j] + " ");
            }
            Console.WriteLine();
        }
        Console.WriteLine("=======");
        return array;
    }
    else{
        Console.WriteLine("Нет стольких уникальных двухзначных чисел.");
        Console.WriteLine("Возвращаю нулевой массив");
        return array;
    }
}

bool arrayContains(int[,] array,int number){
    for (int i = 0; i < array.GetLength(0);i++){
        for (int j = 0; j < array.GetLength(1);i++){
            if (array[i,j] == number){
                return true;
            }
        }
    }
    return false;
}

void Array2DPrint(int[,] matrix){
    for (int i = 0; i<matrix.GetLength(0); i++){
        for (int j = 0; j < matrix.GetLength(1); j++){
            Console.Write(matrix[i,j] + " ");
        }
        Console.WriteLine();
    }
}