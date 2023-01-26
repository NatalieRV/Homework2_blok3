// Ввести цисло, вывести третью цифру числа или сообщить, что ее нет.

int number = 805683;
int index = 0;      // переменная-флажок

if (number < 100)
{
    index = 1;
};

while (number > 1000)
{
    number = number / 10;
};

int position12 = number / 10;
int position3 = number - position12 * 10;

if (index == 0)
{
    Console.WriteLine(position3);
}
else
{
    Console.WriteLine("Третьей цифры нет");
};



