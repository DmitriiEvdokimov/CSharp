// Дан текст. В тексте нужно все пробелы заменить черточками,
// маленькие буквы “к” заменить большими “К”, а большие “С” заменить
// маленькими “с”

// — Я думаю, — сказал князь, улыбаясь, — что,
// ежели бы вас послали вместо нашего милого
// Винценгероде, вы бы взяли приступом согласие
// прусского короля. Вы так красноречивы. Вы
// дадите мне чаю?

string text = "— Я думаю, — сказал князь, улыбаясь, — что,"
+ "ежели бы вас послали вместо нашего милого"
+ " Винценгероде, вы бы взяли приступом огласие"
+ "пруССкого короля. Вы так красноречивы. Вы"
+ " дадите мне чаю?";

string Mark(string str, char symbOld, char symbNew)
{
    string result = String.Empty;
    int length = text.Length;

    for (int i = 0; i < length; i++)
    {
        if (str[i] == symbOld)
        {
            result = result + $"{symbNew}";
        }
        else
        {
            result = result + $"{str[i]}";
        }
    }
    return result;
}

Console.Clear();
Console.WriteLine(text);
Console.WriteLine();


string newText = Mark(text, ' ', '|');
Console.WriteLine(newText);
Console.WriteLine();
newText = Mark(newText, 'к', 'К');
Console.WriteLine(newText);
Console.WriteLine();
newText = Mark(newText, 'С', 'с');
Console.WriteLine(newText);





