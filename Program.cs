// int totalExercises = 8;
// for (int number = totalExercises; number >= 1; number--) {
//     Console.WriteLine($"Упражнение {number}");
// }
// Console.WriteLine("Домашнее задание готово");

// for (int room = 5; room <= 50; room += 5)
// {
//     Console.WriteLine($"Кабинет {room}");
// }
// int totalWeeks = 3;
// for (int week = 1; week <= totalWeeks; week++) {
//     for (int day = 1; day <= 5; day++) {
//         Console.WriteLine($"Неделя {week}, день {day}");
//     }
//     Console.WriteLine("^_^"); 
// }

// int skippedTickets = 0;
// for (int ticket = 1; ticket <= 30; ticket++) {
//     if (ticket == 4 || ticket == 12 || ticket == 19) {
//         skippedTickets++;
//         continue;
//     }
//     Console.WriteLine($"Первый доступный билет: {ticket}");
//     Console.WriteLine($"Пропущено билетов: {skippedTickets}");
//     break;
// }

// for (; ; ) {
//     Console.Write("Введите код группы (для выхода — «выход»): ");
//     string groupCode = Console.ReadLine();

//     if (groupCode == "выход") {
//         break;
//     }
//     Console.WriteLine($"Записан код группы: {groupCode}");
// }
// Console.WriteLine("Работа с журналом завершена");

// // Задача А
// int N = 20;
// for (int i = 1; i <= N; i++) {
//     if (i % 2 != 0) {
//         Console.WriteLine(i);
//     }
// }

// // Задача Б
// for (int i = 100; i >= 0; i -= 10)
// {
//     Console.WriteLine(i);
// }

// // Задача В
// for (int i = 1; i <= 9; i++) {
//     for (int j = 1; j <= 9; j++) {
//         Console.WriteLine($"{i} x {j} = {i * j}");
//     }
// }

// // Задача Г
// for (int i = 1; i <= 50; i++) {
//     if (i % 3 == 0) {
//         continue;
//     }
//     if (i % 7 == 0) {
//         Console.WriteLine($"Найдено число, кратное 7: {i}");
//         break;
//     }
// }

// Console.Write("Введите свою фамилию: ");
// string surname = Console.ReadLine()!.Trim();

// if (string.IsNullOrEmpty(surname)) {
//     Console.WriteLine("Фамилия не введена. Завершение работы.");
//     return;
// }
// Random rnd = new(surname.GetHashCode() + DateTime.Now.DayOfYear);

// var assigned = Enumerable.Range(1, 10)
//     .OrderBy(_ => rnd.Next())
//     .Take(2)
//     .OrderBy(x => x)
//     .ToList();

// Console.WriteLine($"Задачи: №{assigned[0]} и №{assigned[1]}");



// //1 и 7 Степовой

// // Задача 1
// int N = 25;
// for (int i = 1; i <= N; i++)
// {
//     if (i % 3 == 0)
//     {
//         Console.WriteLine(i);
//     }
// }

// Задача 7
// for (int a = 1; a <= 5; a ++)
// {
//     for (int b = 1; b <= 5; b++)
//     {
//         Console.WriteLine($"{a} + {b} = {a + b}");
//     }
// }

// Варианты Сокур (3, 4)
// Задача 3
// int N = int.Parse(Console.ReadLine());
// for (int i = 1; i <= N; i++)
// {
//     Console.WriteLine($"{i} ** 3 = {i * i * i}");
// }

// Задача 4
// int N = int.Parse(Console.ReadLine());
// for (int i = 1; i <= N; i++)
// {
//     for (int j = 1; j <= i; j++)
//     {
//         Console.Write("*");
//     }
//     Console.WriteLine();
// }
