// 1.1 Задание
// for (int i = 10; i>0; i--) {
//     Console.WriteLine(i);
// }
// 1.2 
// for (int i = 1; i<51; i++) {
//     if (i % 2 == 1) continue;
//     Console.WriteLine(i);
// }

// 2 задание
// int sum = 0;
// int count = 0;
// for (int i = 1; i<=100; i++) {
//     if (i % 3 == 0) sum += i;
//     if (i % 7 == 0) count += 1;
    
// }
// Console.WriteLine($"{sum}, {count}");

// 3 задание

// int number = Convert.ToInt32(Console.ReadLine());
// int minus_count = 0;
// int plus_count = 0;
// while (number != 0) {
//     if (number > 0) plus_count++;
//     if (number < 0) minus_count++;
//     number = Convert.ToInt32(Console.ReadLine());
// }

// Console.WriteLine($"-:{minus_count}, +:{plus_count}");


// 4 

// string password;
// int count = 0;
// do
// {
//     Console.Write("input password: ");
//     password = Console.ReadLine();
//     count += 1;
//     if (count == 3) {
//         Console.WriteLine("Доступ заблокирован");
//          break;
//     } ;
// }
// while (password != "qwerty");
// if (password == "qwerty") {
//     Console.WriteLine("Доступ разрешен");
// }

// 5 задание

// int n = Convert.ToInt32(Console.ReadLine());
// for (int i = 1; i<=10; i++) {
//     Console.WriteLine($"{n} x {i} = {n*i}");
// }

//6 задание
// for (int i = 1; i<=30; i++) {
//    if (i % 3 == 0) continue;
//    if (i % 10 == 0) break;
//    if (i > 20) break;
//    Console.WriteLine(i);
// } 

// Угадай число

int secret = 48;
int try_count = 1;
Console.WriteLine("Угадай число: ");
int input = Convert.ToInt32(Console.ReadLine());

while (input != secret) {
    
    if (input < secret) {
        Console.WriteLine("Больше");
    }
    else if (input > secret) {
        Console.WriteLine("Меньше");
    }
    if (try_count == 5) {
    Console.WriteLine($"Вы проиграли число было {secret}");
    break;
    }
    
    
    input = Convert.ToInt32(Console.ReadLine());
    try_count++;
}


if (input == secret) {
        Console.WriteLine($"Победа! Попыток: {try_count}");
    };
