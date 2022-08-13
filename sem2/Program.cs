int randomNumber = new Random().Next(10, 100);

int FirstDigit = randomNumber / 10;
int SecondGigit = randomNumber % 10;

if(FirstDigit > SecondGigit)
{
    Console.WriteLine(FirstDigit);
}
else
{
    Console.WriteLine(SecondGigit);
}
int GetRandomNumber(int min, int max)
{
    return new Random();
}