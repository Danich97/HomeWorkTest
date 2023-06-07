int x = 78945;

int firstNumber = x / 10000;
int secondNumber = (x / 1000 - firstNumber * 10);
int thirdNumber = (x - firstNumber * 10000 - secondNumber * 1000) / 100;
int fourthNumber = (x - firstNumber * 10000 - secondNumber * 1000 - thirdNumber * 100) / 10;
int fifthNumber = (x - firstNumber * 10000 - secondNumber * 1000 - thirdNumber * 100 - fourthNumber * 10);

Console.WriteLine(firstNumber);
Console.WriteLine(secondNumber);
Console.WriteLine(thirdNumber);
Console.WriteLine(fourthNumber);
Console.WriteLine(fifthNumber);