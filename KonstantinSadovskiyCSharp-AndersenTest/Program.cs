using System.Text;

Console.OutputEncoding = Encoding.UTF8;
Console.InputEncoding = Encoding.GetEncoding("utf-16");

int num;
string numInput;
while (true)
{
    Console.WriteLine("Введите целое число");
    numInput = Console.ReadLine();

    if (numInput != null)
    {
        bool parseSuccess = Int32.TryParse(numInput, out num);
        if (parseSuccess) { break; }
    }

    Console.WriteLine("Вы ввели не целое число");
}

if (num > 7)
{
    Console.WriteLine("Привет");
}

string name;
while (true)
{
    Console.WriteLine("Напишите имя");
    name = Console.ReadLine();
    if ( name != null) { break; }
    Console.WriteLine("Вы не ввели имя");
}

if (name == "Вячеслав")
{
    Console.WriteLine("Привет, Вячеслав");
}
else
{
    Console.WriteLine("Нет такого имени");
}

string numArrInput;
List<int> numList = new List<int>();
while (true)
{
    numList.Clear();   
    Console.WriteLine("Введите массив целых чисел (через пробел)");
    numArrInput = Console.ReadLine();
    if (numArrInput != null)
    {
        string[] numArrString = numArrInput.Trim().Split(' ');

        bool parseSuccess = true;
        foreach (string numString in numArrString)
        {
            int number;
            bool parseNumSuccess = Int32.TryParse(numString, out number);
            if (!parseNumSuccess)
            {
                parseSuccess = false;
                break;
            }
            numList.Add(number);
        }

        if (parseSuccess)
        {
            break;
        }

    }
    Console.WriteLine("Вы ввели не целое число или лишний пробел");
}

List<int> numDivBy3List = new List<int>();
foreach (int number in numList)
{
    if (number % 3 == 0)
    {
        numDivBy3List.Add(number);
    }
}
Console.WriteLine("Числа кратные трём:");
Console.WriteLine(String.Join(" ", numDivBy3List.ConvertAll<string>(x => x.ToString())));
