// Алгоритм БЫСТРОЙ сортировки

Main(args);

static void Main(string[] args)
{
    int[] array = { 4, 8, 5, 6, 9, 4, -6, -1, 32, 50, 4, 7, 8, 33, 3, -8 };

    for (int j = 0; j < array.Length; j++)
    {
        Console.Write($" {array[j]} ");
    }
    Console.WriteLine();

    array = QickSort(array, 0, array.Length - 1);

    for (int j = 0; j < array.Length; j++)
    {
        Console.Write($" {array[j]} ");
    }

}







static int FindPivod(int[] array, int minIndex, int maxIndex)

{

    int pivot = minIndex - 1; //принимаем индекс опорного элемента как -1
    int temp = 0; //(сокращение от temporary (временный))



    for (int i = minIndex; i < maxIndex; i++)

    //отнимаем -1 от длины массива т.к принимаем 
    // за опорный элемент последний элемент массива

    {
        //если элемнт массива под индексом i меньше чем опорный элемент,
        //тогда прибавляем 1 к индексу опорного элемента

        if (array[i] < array[maxIndex])
        {
            pivot++;
            temp = array[pivot];      //вносим элемент массива в временную переменную temp
            array[pivot] = array[i];  //меняем местами элемент массива с индексом i и индексом pivod
            array[i] = temp;          // запоминаем элемент массива под индексом i
        }
    }
    pivot++;
    temp = array[pivot];
    array[pivot] = array[maxIndex];  //меняем местами элемент массива с индексом i и индексом pivod
    array[maxIndex] = temp;

    return pivot;
}



static int[] QickSort(int[] array, int minIndex, int maxIndex)
{
    //УСЛОВИЕ остановки РУКУРСИВНОЙ функции QickSort
    if (minIndex >= maxIndex)
    {
        return array;
    }

    //присваиваем переменной pivot значение из метода FindPivod 
    //(получаем индекс опорного элемента)

    int pivot = FindPivod(array, minIndex, maxIndex);

    //РЕКУРСИЯ .Вызываем функцию QickSort для сортировки элементов 
    //ДО опорного элемента

    QickSort(array, minIndex, pivot - 1);

    //РЕКУРСИЯ .Вызываем функцию QickSort для сортировки элементов 
    //ПОСЛЕ опорного элемента

    QickSort(array, pivot + 1, maxIndex);

    //после каждого вызова ф-ий QickSort возвращаем 
    //обновленный массив "НАРУЖУ"

    return array;

}



