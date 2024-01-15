using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp11
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //1. Обработать тестовое задание по информатике. На экран вывести вопрос и три варианта ответа, ввести с экрана вариант ответа.
            //Программа должна оценить ответ и в случае неправильного ответа написать правильный.

            //Console.WriteLine("Кто создал информатику?");
            //Console.WriteLine("1)Карл Штейнбух");
            //Console.WriteLine("2)Тома де Кольмару");
            //Console.WriteLine("3)А.С.Пушкин");
            //Console.WriteLine("Введите вариант ответа");
            //int x = int.Parse(Console.ReadLine());
            //if (x == 1) 
            //{
            //    Console.WriteLine("Верно");
            //}
            //else
            //{
            //    Console.WriteLine("Не верно!Правильный ответ 1)Карл Штейнбух");
            //}

            //2.Написать программу вычисления стоимости переговоров, если по субботам и воскресеньям
            //предоставляется 20 % скидка.Ввести продолжительность разговора и день недели(цифра от 1 до 7).

            //Console.Write("Cтоимость переговоров(за минуту): ");
            //int x = int.Parse(Console.ReadLine());
            //Console.Write("Какое продолжительность разговора: ");
            //int a = int.Parse(Console.ReadLine());
            //Console.Write("Какой день недели: ");
            //int b = int.Parse(Console.ReadLine());
            //int c = x * a; 
            //int d = (c * 20) / 100; 
            //switch (b)
            //{
            //    case 1: case 2: case 3: case 4: case 5: Console.WriteLine(c);break;
            //    case 6: case 7: Console.WriteLine(c-d);break;
            //}



            //3.Написать программу для определения времени суток по данному текущему времени и вывести сообщение
            //(утро – с 6 до 12, день – с 12 до 18, вечер – с 18 до 24, ночь – с 0 до 6).

            //Console.Write("Введите текущее время: ");
            //int time = int.Parse(Console.ReadLine());

            //if (time >= 6 && time < 12)
            //{
            //    Console.WriteLine("Утро");
            //}
            //if (time >= 12 && time < 18)
            //{
            //    Console.WriteLine("День");
            //}
            //if (time >= 18 && time < 24)
            //{
            //    Console.WriteLine("Вечер");
            //}
            //if (time >= 0 && time < 6)
            //{
            //    Console.WriteLine("Ночь");
            //}


            //4. Рейтинг бакалавра заочного отделения при поступлении в магистратуру определяется средним баллом по диплому,
            //умноженным на коэффициент стажа работы по специальности, который равен: нет стажа – 1, меньше 2 лет – 13, от 2 до 5 лет – 16.
            //Составить программу расчета рейтинга при заданном среднем балле диплома (от 3 до 5) и вывести сообщение
            //о приеме в магистратуру при проходном балле 45.

            //Console.WriteLine("Введите средний балл диплома: ");
            //int a = int.Parse(Console.ReadLine());
            //Console.WriteLine("Введите свой стаж работы: ");
            //int b = int.Parse(Console.ReadLine());
            //int c = 0;

            //if(b == 0)
            //{
            //    c = 1;
            //}
            //else if (b == 1 || b == 2)
            //{
            //    c = 13;
            //}
            //else if (b >= 2 || b <=5)
            //{
            //    c = 16;
            //}
            //int d = a * c;
            //if (d >= 45) 
            //{
            //    Console.WriteLine("Вы приняты в магистратуру");
            //}
            //else
            //{
            //    Console.WriteLine("Вы не приняты в магистратуру");
            //}






            //5.Написать программу , которая по дате рождения(день d месяц n) определяет знак Зодиака: с 22 марта по 21 апреля - Овен(4); с 22 апреля по 21 мая - Телец(5);
            //с 22 мая по 21 июня - Близнецы(6); с 22 июня по 21 июля - Рак(7); с 22 июля по 21 августа - Лев(8); с 22 августа по 21 сентября - Дева(9);
            //22 сентября по 21 октября - Весы(10); с 22 октября по 21 ноября - Скорпион(11); с 22 ноября по 21 декабря - Стрелец(12);
            //с 22 декабря по 21 января - Козерог(1); 22 января по 21 февраля - Водолей(2); с 22 февраля по 21 марта - Рыбы(3).


            //{Console.Write("Введите  день своего рождения: ");
            //int d = int.Parse(Console.ReadLine());
            //Console.Write("Введите месяц своего рождения: ");
            //int n = int.Parse(Console.ReadLine());
            //if (d >= 22 && n == 12 || d <= 21 && n == 1)
            //{
            //    Console.WriteLine("Козерог");
            //}
            //if (d >=22 && n == 1 || d <= 21 && n == 2 )
            //{
            //    Console.WriteLine("Водолей");
            //}
            //if (d >= 22 && n == 2 || d <=21 && n == 3)
            //{
            //    Console.WriteLine("Рыбы");
            //}

            //if (d >= 22 && n == 3 || d <= 21 && n == 4)
            //{
            //    Console.WriteLine("Овен");
            //}
            //if (d >= 22 && n == 4 || d <= 21 && n == 5)
            //{
            //    Console.WriteLine("Телец");
            //}
            //if (d >= 22 && n == 5 || d <= 21 && n == 6)
            //{
            //    Console.WriteLine("Близнецы");
            //}
            //if (d >= 22 && n == 6 || d <= 21 && n == 7)
            //{
            //    Console.WriteLine("Рак");
            //}
            //if (d >= 22 && n == 7 || d <= 21 && n == 8)
            //{
            //    Console.WriteLine("Лев");
            //}
            //if (d >= 22 && n == 8 || d <= 21 && n == 9)
            //{
            //    Console.WriteLine("Дева");
            //}
            //if (d >= 22 && n == 9 || d <= 21 && n == 10)
            //{
            //    Console.WriteLine("Весы");
            //}
            //if (d >= 22 && n == 10 || d <= 21 && n == 11)
            //{
            //    Console.WriteLine("Скорпион");
            //}
            //if (d >= 22 && n == 11 || d <= 21 && n == 12)
            //{
            //    Console.WriteLine("Стрелец");
            //}



            //6.Написать программу, которая при вводе числа в диапазоне от 1 до 99 добавляет к нему слово "копейка" в правильной форме.Например, 1 копейка, 5 копеек, 42 копейки.
            //Console.Write("Введите число: ");
            //int a = int.Parse(Console.ReadLine());
            //Console.Write(a + " ");
            //if (a % 10>=5 || a % 10 <= 0 || a >= 5 & a  <=20)
            //{
            //    Console.WriteLine("копеек");
            //}
            //else if (a % 10 == 1)
            //{
            //    Console.WriteLine("копейка");
            //}
            //else if (a % 10 == 2 || a % 10 == 3 || a % 10 ==4)
            //{
            //    Console.WriteLine("копейки");
            //}


            //7.Написать программу, которая после введенного с клавиатуры числа в диапазоне от 1 до 99 дописывает слово «рубль» в правильном падеже.
            //Console.Write("Введите число: ");
            //int a = int.Parse(Console.ReadLine());
            //Console.Write(a + " ");
            //if ( a % 10>= 5 || a % 10 <= 0 || a >= 5 & a <=20)
            //{
            //    Console.WriteLine("рублей");
            //}
            //else if (a % 10 == 1)
            //{
            //    Console.WriteLine("рубль");
            //}
            //else if (a % 10 == 2 || a % 10 ==3 || a % 10 == 4 )
            //{
            //    Console.WriteLine("рубля");
            //}
            //Console.ReadKey();
        }
    }
}
