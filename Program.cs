// Напишите программу, которая принимает на вход координаты двух точек и находит расстояние между ними в 3D пространстве.

Console.Clear();
Console.WriteLine("Задача 21: программа находит расстояние между двумя точками в 3D пространстве\n");
Console.WriteLine("Введите координаты точки А:\n");
var coorAfirst = checkCoor("");
var coorAsecond = checkCoor("");
var coorAthird = checkCoor("last");
Console.WriteLine("\nВведите координаты точки B:\n");
var coorBfirst = checkCoor("");
var coorBsecond = checkCoor("");
var coorBthird = checkCoor("last");

var result = Math.Sqrt(Math.Pow((coorBfirst - coorAfirst),2) + Math.Pow((coorBsecond - coorAsecond),2) + Math.Pow((coorBthird - coorAthird),2));

Console.WriteLine("\nРасстояние между точками с введёнными координатами = " + result.ToString("N2"));


int checkCoor(string str) {
    while(true) {
        var text = Console.ReadLine();
        if(int.TryParse(text, out int number)) {
            if (str != "last") Console.WriteLine("\nвведите следующую координату этой же точки:\n");
            return number; }
        else Console.WriteLine("Неправильно введена координата точки, повторите ввод:\n");
}
}