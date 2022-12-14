// Пользователь вводит с клавиатуры М чисел.
// Посчитайте, сколько чисел больше 0 ввёл пользователь.
Console.Clear();

Console.Write("Введите количество чисел (M): ");
int m=Convert.ToInt32(Console.ReadLine());

int[] nums = InpArr(m);

Console.WriteLine($"Количество положительных элементов: {CountPosNum(nums)}.");

int[] InpArr(int size)
{
    int[] resArr=new int [size];

    for(int i=0; i<size; i++)
    {
        Console.Write($"Введите число {i+1}: ");
        resArr[i]=Convert.ToInt32(Console.ReadLine());
    }
    return resArr;
}

int CountPosNum(int[] nums)
{
    int result=0;
    
    for(int i=0; i<nums.Length; i++)
        if(nums[i]>0)
            result++;

    return result;
}