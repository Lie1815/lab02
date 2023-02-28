// See https://aka.ms/new-console-template for more information
Console.WriteLine("Введите коэфф a");
double firsNumber = Convert.ToDouble(Console.ReadLine());

Console.WriteLine($"{firsNumber}^3*{firsNumber}={Math.Pow(firsNumber,3)*firsNumber}");
Console.WriteLine("необходимо внети второй коэфф");


Console.WriteLine($" ");

double secondnumber = Convert.ToDouble(Console.ReadLine());
double thirdnumber = Convert.ToDouble(Console.ReadLine());

Console.WriteLine($"({firsNumber}+{secondnumber})*({firsNumber}^2-{firsNumber}*{secondnumber}+{secondnumber}^2)={(firsNumber + secondnumber)*(Math.Pow(firsNumber, 2) - firsNumber*secondnumber + Math.Pow(secondnumber,2))}");
Console.WriteLine($"({firsNumber}-{secondnumber})*({firsNumber}^2+{firsNumber}*{secondnumber}+{secondnumber}^2)={(firsNumber - secondnumber)*(Math.Pow(firsNumber, 2) + firsNumber*secondnumber + Math.Pow(secondnumber,2))}");
Console.WriteLine($"({firsNumber} - {secondnumber} *({firsNumber} + {secondnumber}");
Console.WriteLine($"({firsNumber}^2-2*{firsNumber}*{secondnumber}+{secondnumber}^2) = {(Math.Pow(firsNumber,2) - 2 * firsNumber * secondnumber + Math.Pow(secondnumber, 2))}");
Console.WriteLine($"({firsNumber}^2+2*{firsNumber}*{secondnumber}+{secondnumber}^2) = {(Math.Pow(firsNumber,2) + 2 * firsNumber * secondnumber + Math.Pow(secondnumber, 2))}");
Console.WriteLine($"({firsNumber}^3-3{firsNumber}^2{secondnumber}+3{firsNumber}*{secondnumber}^2-{secondnumber}^3) = {(Math.Pow(firsNumber,3 ) - 3 * Math.Pow(firsNumber,2) * secondnumber + 3 * firsNumber * Math.Pow(secondnumber, 2) - Math.Pow(secondnumber, 3))}");
Console.WriteLine($"({firsNumber}^3+3{firsNumber}^2{secondnumber}+3{firsNumber}*{secondnumber}^2+{secondnumber}^3) = {(Math.Pow(firsNumber,3 ) + 3 * Math.Pow(firsNumber,2) * secondnumber + 3 * firsNumber * Math.Pow(secondnumber, 2) + Math.Pow(secondnumber, 3))}");
//(a-a^1/2 -a^c)
double resultFirstFunc = firsNumber-Math.Pow(firsNumber, 0.5) - Math.Pow(firsNumber, thirdnumber);
Console.WriteLine(resultFirstFunc);
// (a^2-2ab+b^2)
double resultSecondFunc = Math.Pow(firsNumber , 2) - 2 * firsNumber * secondnumber + Math.Pow(secondnumber, 2);
if (resultFirstFunc != 0 && resultSecondFunc != 0 ) {

    Console.WriteLine($"((({firsNumber}^ 2-4*{secondnumber}*{thirdnumber}/({firsNumber} - {firsNumber}*1/2-{firsNumber}*{thirdnumber})-({firsNumber}*{secondnumber}*{thirdnumber})*3)/({secondnumber}2-2{firsNumber}*{secondnumber}+b{secondnumber}*2) ={((Math.Pow(firsNumber, 2) - 4*secondnumber * thirdnumber) / resultFirstFunc) -  Math.Pow(firsNumber * secondnumber * thirdnumber,3) / resultSecondFunc}");
}
else
{
    Console.WriteLine("деление на ноль");
}



//a^2+2ab+b^2;
//a^3-3a^2b+3ab^2-b^3;
//a^3+3a^2b+3ab^2+b^3;
//((a2-4bc)/(a - a1/2-ac)-(abc)3)/(a2-2ab+b2);
Console.WriteLine("Введите количество вероятностей");
int n = Convert.ToInt32(Console.ReadLine());
double sumP = 0;
for (int i = 1; i <= n ; i++) {
   
    Console.WriteLine("Введите число ");
    double p = Convert.ToDouble(Console.ReadLine());
    Console.WriteLine($"Вы ввели {p}. Итерация {i}");
    sumP+= p * Math.Log(p,2);
}   

Console.WriteLine(sumP * (-1));
Console.ReadKey();

