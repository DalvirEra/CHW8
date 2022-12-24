int[,] array = arraygen();


int line = -1;
int minSum = int.MaxValue;
int sum;
for (int i = 0; i<array.GetLength(0); i++){
    sum = 0;
    for (int j = 0; j < array.GetLength(1); j++){
        sum += array[i,j];
    }
    Console.WriteLine("Сумма строчки "+ (i+1)+ ": " + sum);
    if (sum < minSum){
        minSum = sum;
        line = i+1;
    }
}
Console.WriteLine("Наименьшая строка " + line);
Console.WriteLine("Наименьшая сумма " + minSum);

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