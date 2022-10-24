// Задача 41: Пользователь вводит с клавиатуры M чисел. 
// Посчитайте, сколько чисел больше 0 ввёл пользователь.
// 0, 7, 8, -2, -2 -> 2
// 1, -7, 567, 89, 223-> 3

int[] GetArrayFromString(string stringArray)
{
    string[] nums = stringArray.Split(" ", StringSplitOptions.RemoveEmptyEntries);
    int[] res = new int[nums.Length];

    for (int i = 0; i < nums.Length; i++)
    {
        res[i] = int.Parse(nums[i]);
    }
    return res;
}

int Calculation(int[] massive)
{
    int res = 0; 
    foreach (int el in massive)
    {
        if(el > 0)
        {
            res++;
        }
    }
    return res;
}

Console.Clear();
Console.WriteLine("Введите числа через пробел: ");
string input = Console.ReadLine()!;
int[] array = GetArrayFromString(input);
int result = Calculation(array);
Console.WriteLine($"Пользователь ввел {result} чисел больше 0");
