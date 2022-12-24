int[,] array = arraygen();


//тоже можно кинуть в функцию, но тогда кода не останется =)
bool change;
for (int i = 0; i<array.GetLength(0); i++){ // каждую строку
    int temp;
    change = true;
    while (change) { // если не было ни одного изменения за цикл, прекратить
        change = false;
        for (int j = 0; j < array.GetLength(1); j++){ // каждой цифре в строке
            if (j != array.GetLength(1)-1 && array[i,j] < array[i,j+1]){ // сортировка
                temp = array[i,j];
                array[i,j] = array[i,j+1];
                array[i,j+1] = temp;
                change = true;
            }
        }
    }
}


Console.WriteLine("Сортированный массив:");
Array2DPrint(array);

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

void Array2DPrint(int[,] matrix){
    for (int i = 0; i<matrix.GetLength(0); i++){
        for (int j = 0; j < matrix.GetLength(1); j++){
            Console.Write(matrix[i,j] + " ");
        }
        Console.WriteLine();
    }
}