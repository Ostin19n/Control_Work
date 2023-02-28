// Написать программу, которая из имеющегося массива строк формирует массив из строк, 
// длина которых меньше либо равна 3 символа. Первоначальный массив можно ввести с клавиатуры, 
// либо задать на старте выполнения алгоритма. 
// При решение не рекомендуется пользоваться коллекциями, лучше обойтись исключительно массивами


int GetNum(string text)
{
    Console.Write(text);
    int size = int.Parse(Console.ReadLine());
    return size;
}
    int numberN = GetNum("Введите количество элементов: ");


int size = numberN;
string[] arrayLine = new string[size];
for (int i = 0; i < size; i++)
{
    Console.WriteLine($"Введите {i + 1}-й элемент: ");
    string element = Convert.ToString(Console.ReadLine())!;
    arrayLine[i] = element;
}