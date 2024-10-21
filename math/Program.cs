using System;

int width = GetValidNumber("Insert width: ");
int height = GetValidNumber("Insert height ");
static int GetValidNumber(string text)
{
    int number = 0;
    bool isValid = false;

    while (!isValid)
    {
        Console.WriteLine(text);
        string input = Console.ReadLine();

        if (int.TryParse(input, out number))
        {
            isValid = true;
        }
        else
        {
            Console.WriteLine("Invalid input, please try a number.");
        }
    }
    return number;
}

Console.WriteLine(width * height);