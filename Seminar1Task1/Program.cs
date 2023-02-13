// является ли первое число квадратом второго??

//  вводим переменные

Console.WriteLine("введите 2 числа через пробел:");

 string numLine1 = Console.ReadLine();
 string numLine2 = Console.ReadLine();
 
//  проверяем чтобы данные не были пустыми
if (numLine1 != null && numLine2 != null)
 {
    //присваеваем переменным значения
    int num1 = int.Parse(numLine1);
    int num2 = int.Parse(numLine2);
// если квадрат второго числа равен первому
    if (num2*num2 == num1)
    {
        //выводим положительный ответ
        Console.WriteLine("да");
        }

        else
 {
    //выводим отрицательный ответ
     Console.WriteLine("нет");
 }        
 }

 