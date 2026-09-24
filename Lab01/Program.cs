// //комната
// Console.WriteLine();
// Console.WriteLine("Ремонт: комната");

// double roomWidth = 3.5;
// double roomLength = 4.2;

// double roomArea = roomWidth * roomLength;  
// double roomPerimeter = (roomWidth + roomLength) * 2; 

// Console.WriteLine($"Ширина: {roomWidth} м, длина: {roomLength} м");
// Console.WriteLine($"Площадь: {roomArea} кв.м");
// Console.WriteLine($"Периметр: {roomPerimeter}");

// //ноутбук
// Console.WriteLine();
// Console.WriteLine("Покупка ноутбука в рассрочку");

// int laptopPrice = 65000;
// int monthsCount = 12;
// double interestRate = 0.08;

// // этот блок кода определяет площадь и периметр комнаты
// double totalWithInterest = laptopPrice * (1 + interestRate); 
// double monthlyPayment = totalWithInterest / monthlyPayment;  

// Console.WriteLine($"Цена ноутбука: {laptopPrice} руб.");
// Console.WriteLine($"Итого с процентами: {totalWithInterest} руб");
// Console.WriteLine($"Платёж в месяц: {monthlyPayment}");

// //деление
// Console.WriteLine();
// Console.WriteLine("Внимание: деление int");

// int totalStudents = 25;
// int groupsCount = 4;

// int studentsPerGroupWrong = totalStudents / groupsCount;
// double studentsPerGroupCorrect = (double)totalStudents / groupsCount; //double нужен для того чтобы округлить число

// Console.WriteLine($"25 / 4 как int: {studentsPerGroupWrong}");
// Console.WriteLine($"25 / 4 как double: {studentsPerGroupCorrect}");

// //Строки
// Console.WriteLine();
// Console.WriteLine("Способы собрать строку");

// string firstName = "Заур";
// string lastName = "Магдеев";

// //Способ 1
// string fullNameConcat = firstName + " " + lastName;

// //Способ 2
// string fullNameInterp = $"{firstName} {lastName}";

// //Способ 3
// string fullNameConcatMethod = string.Concat(firstName, " ", lastName);

// Console.WriteLine(fullNameConcat);
// Console.WriteLine(fullNameInterp);
// Console.WriteLine(fullNameConcatMethod);
// Console.WriteLine($"Все три строки равны: {fullNameConcat == fullNameInterp && fullNameInterp == fullNameConcatMethod}");

// //Константы
// Console.WriteLine();
// Console.WriteLine("Константы");

// const double VatRate = 0.20;
// const string CollegeName = "ВФ ВолГУ";

// double productPrice = 1000;
// double priceWithVat = productPrice * (1 + VatRate);

// Console.WriteLine($"Ученое заведение: {CollegeName}");
// Console.WriteLine($"Цена без НДС: {productPrice}, с НДС ({VatRate:P0}): {priceWithVat}");


// //Задание 1. Финансовыймини-расчёт ★
// int scholarship = 4500;
// int monthlyExpenses = 2500;
// const int MonthsInSemester = 4;

// Console.WriteLine($"Денег осталось к концу месяца: {scholarship - monthlyExpenses}");
// Console.WriteLine($"За семестр месяца останется: {(scholarship - monthlyExpenses) * MonthsInSemester}.");



//Задание 3. Найди и исправь ошибку ★★★
int totalMinute = 500;
int minutePerLesson = 45;
int FullSession = totalMinute / minutePerLesson;
int ExSession = totalMinute % minutePerLesson;
Console.WriteLine($"{totalMinute} минут = {FullSession} полных занятий + {ExSession} минут.");