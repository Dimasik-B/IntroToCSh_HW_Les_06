Console.Write("Введите строку чисел: ");
string numbers = Console.ReadLine();
Console.WriteLine($"Количество чисел больше 0: {GetNumberOfPositives(numbers)}");

int GetNumberOfPositives (string numbers){
    int count = 0;
    string[] array = numbers.Split(new char[] {' ', ','}, StringSplitOptions.RemoveEmptyEntries);
    foreach (string el in array){
        if (int.TryParse(el, out int temp) && temp > 0) count++;
    }
    return count;
}