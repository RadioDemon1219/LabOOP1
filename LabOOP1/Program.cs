using System.Text;


bool value1 = true;
byte value2 = 255;
sbyte value3 = -124;
char value4 = 'a';
decimal value5 = 10000;
int value6 = 2345;
uint value7 = 53456;
nint value8 = 0;
nuint value9 = 123456;
long value10 = 123131232;
ulong value11 = 1231231312313233121;
short value12 = 12323;
ushort value13 = 65333;




byte a = 10;
int b = a;

int c = 1000;
long d = c;

float e = 3.14f;
double f = e;

char g = 'A';
int h = g;

int i = 50;
float j = i;



double k = 123.45;
int l = (int)k;

int m = 300;
byte n = (byte)m;

long o = 100000;
int p = (int)o;

float q = 10.5f;
int r = (int)q;

object s = "text";
string t = (string)s;

int myIntValue = 123;
Convert.ToDouble(myIntValue);//Привели переменную в тип double


string myString = null;
if (myString == null)
{
    Console.WriteLine("У переменной " + myString + " отсутствует значение");
}
else
{
    Console.WriteLine("У переменной " + myString + " есть значение");
}

var var1 = 12;
//var1 = "asdasd";
Convert.ToDouble(var1);

string str1 = "Kotik";
string str2 = "kotik";
bool str12 = str1 == str2;
Console.WriteLine(str12);//Выведет False



string Stroka1 = "Имя";
string Stroka2 = "Фамилия";
string Stroka3 = "Отчество";
//Копирование
string copyStroku = string.Copy(Stroka1);

//Сцепление
string NewStroka12 = Stroka1 + Stroka2;//NewStroka12=ИмяФамилия

//Выделение подстроки
string subString3 = Stroka3.Substring(0, 5); //subString3="Отчес"

//Разделение строки на слова
string sentence = "Разделение строки на слова";
string[] words = sentence.Split(' ');
foreach (var word in words)
    Console.WriteLine(word);

//Вставка подстроки в заданную позицию
string inserted = Stroka3.Insert(7, "замечательный ");

//Удаление подстроки
string str = "Пример строки";
string substr = "строки";
int index = str.IndexOf(substr);
if (index >= 0)
{
    str = str.Remove(index, substr.Length);//str="Пример"
}


//string.IsNullOrEmpty
string nullstr = null;
if (string.IsNullOrEmpty(nullstr) == true)
{
    Console.WriteLine("Строка пуста");
}


StringBuilder strb = new StringBuilder("МегаСтрока3000");
strb.Append("XXXXL");
strb.Insert(0, "Супер");
strb.Remove(5, 10);



int[,] array1 = { { 1, 2, 3, 4, 5 }, { 6, 7, 8, 9, 10 }, { 11, 12, 13, 14, 15 } };
for (int ii = 0; ii < array1.GetLength(0); ii++)
{
    for (int jj = 0; jj < array1.GetLength(1); jj++)
    {
        Console.Write(array1[ii, jj] + " ");
    }
    Console.WriteLine();
}

string[] strArray = { "stroka1", "stroka2", "stroka3" };
for (int ii = 0; ii < strArray.Length; ii++)
{
    Console.Write(strArray[ii] + " ");
}
Console.WriteLine(strArray.Length);


int[][] jaggedArray = new int[3][];

jaggedArray[0] = new int[2];
jaggedArray[1] = new int[3];
jaggedArray[2] = new int[4];

for (int ii = 0; ii < jaggedArray.Length; ii++)
{
    for (int jj = 0; jj < jaggedArray[ii].Length; jj++)
    {
        Console.Write("Введите значение элемента " + (jj + 1) + " строки " + (ii + 1) + ": ");
        Console.ReadLine();
    }
    Console.WriteLine();
}

for (int ii = 0; ii < jaggedArray.Length; ii++)
{
    for (int jj = 0; jj < jaggedArray[i].Length; jj++)
    {
        Console.Write(jaggedArray[ii][jj]);
    }
}


var numbers = new int[3] { 1, 12, 123 };
var strings = new string[3] { "string", "strin", "stri" };



(int, string, char, string, ulong) turple1 = (12, "stroka", 'a', "stroki", 123123123);

(int, string, char, string, ulong) turple2 = (10, "Stroka", 'b', "strOki", 123123123123);

Console.WriteLine("Вывести кортеж полностью или выборочно? 1-Полностью, 2-Выборочно: ");
int choice = Convert.ToInt32(Console.ReadLine());

if (choice == 1)
{
    Console.WriteLine(turple1);
    return;
}
else if (choice == 2)
{
    while (true)
    {
        Console.WriteLine("Какой элемент вывести от 1 до 5");
        int choice2 = Convert.ToInt32(Console.ReadLine());
        if (choice2 == 1)
        {
            Console.WriteLine(turple1.Item1);
            break;
        }
        else if (choice2 == 2)
        {
            Console.WriteLine(turple1.Item2);
            break;
        }
        else if (choice2 == 3)
        {
            Console.WriteLine(turple1.Item3);
            break;
        }
        else if (choice2 == 4)
        {
            Console.WriteLine(turple1.Item4);
            break;
        }
        else if (choice2 == 5)
        {
            Console.WriteLine(turple1.Item5);
            break;
        }
        else
        {
            Console.WriteLine("Ошибка");

        }
    }
}


int newValue = turple1.Item1;
string newValue2 = turple1.Item2;
char newValue3 = turple1.Item3;
string newValue4 = turple1.Item4;
ulong newValue5 = turple1.Item5;

Console.WriteLine(turple1 == turple2);


int Func1()
{
    checked
    {
        int Value1 = int.MaxValue;
        return Value1;
    }

}
int Func2()
{
    unchecked
    {
        int Value2 = int.MaxValue;
        return Value2;
    }

}
Console.WriteLine(Func1());
Console.WriteLine(Func2());

