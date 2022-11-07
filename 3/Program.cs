// Написать программу масштабирования фигуры
//* tут для тех кто далеко улетел, чтобы задавались вершины фигуры списком (одной строкой)
//например: "(0,0) (2,0) (2,2) (0,2)"
//коэффициент масштабирования k задавался отдельно - 2 или 4 или 0.5
//В результате показать координаты, которые получатся.
//при k = 2 получаем "(0,0) (4,0) (4,4) (0,4)" //

using System.Linq;

string text = "(0,0) (2,0) (2,2) (0,2)"; // Задаем вершины фигуры
Console.WriteLine($"вершины фигуры:2 {text}");
Console.Write("введите коэффициент масштабирования:");
int k = int.Parse(Console.ReadLine()); 

text = text.Replace("(", "").Replace(")","").Replace(","," ");// Заменяем скобки и запятые
string[] strArray = text.Split(" "); // разбиваем строку на массив разделитель пробел " ".
string result = string.Empty;

for (int i = 0; i < strArray.Length; i=i+2)   // выводим координаты с учётом коэффициента
{
     int x = k * int.Parse(strArray[i]);
     int y = k * int.Parse(strArray[i+1]);
     result = result + $"({x},{y}) ";
 }
Console.WriteLine(result);