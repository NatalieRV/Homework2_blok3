// На входе трёхзначное число и на выходе показывает вторую цифру этого числа.

int number = 157;
int position1 = number/100;
int position2 = (number-position1*100)/10;
Console.WriteLine(position2);
