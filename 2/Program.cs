// // Напишите программу, которая принимает на вход пятизначное число и проверяет, является ли оно палиндромом.
//14212 -> нет
//12821 -> да
//23432 -> да

Console.WriteLine("Является ли ваше пятизначное число палиндромом ?");
Console.WriteLine("Введите число для проверки: ");
string? number = Console.ReadLine();


void CheckingNumber(string number){
  if (number[0]==number[4] || number[1]==number[3]){
    Console.WriteLine($"Ваше число: {number} - да");
  }
  else Console.WriteLine($"Ваше число: {number} - нет");
}


if (number!.Length == 5){
  CheckingNumber(number);
}
else Console.WriteLine($"Введите правильное число");