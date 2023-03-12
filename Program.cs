// 41: Пользователь вводит с клавиатуры M чисел. Посчитайте, сколько чисел больше 0 ввёл пользователь.
int n = Convert.ToInt32(Console.ReadLine());
int[] arr = new int[n];
for(int i = 0; i < n; i++) {
    arr[i] = Convert.ToInt32(new Random().Next(-100, 100));
    Console.WriteLine($"{arr[i]} ");
}
int value = 0;
for(int i = 0; i < n; i++) {
    if (arr[i] > 0) value++;
}
Console.Write($"Пользователь ввёл {value} чисел, которые больше нуля");