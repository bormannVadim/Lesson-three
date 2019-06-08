using System;
using System.Threading;

namespace task_1
{
    class Program
    {
        struct Complex
        {
            public double im;
            public double re;

            public  Complex(double number)
            {

                im = number;
                re = number;
            }

            public Complex(double _re, double _im)
            {
                im = _im;
                re = _re;
            }
            //  в C# в структурах могут храниться также действия над данными
            public Complex Plus(Complex x)
            {
                Complex y;
                y.im = im + x.im;
                y.re = re + x.re;
                return y;
            }
            //  Пример произведения двух комплексных чисел
            public Complex Multi(Complex x)
            {
                Complex y;
                y.im = re * x.im + im * x.re;
                y.re = re * x.re - im * x.im;
                return y;
            }
            public string ToString()
            {
                return re + "+" + im + "i: "; 
          }

            public static Complex Sub(Complex one, Complex two)
            {
                Complex ReturnedValue = new Complex(one.re - two.re, one.im - two.im);
                return ReturnedValue;
            }
        }


        static void Main(string[] args)
        {
            // Савенко Вадим
            // Struct
            Complex cn = new Complex(10);
            Console.WriteLine("Первое число: "+cn.ToString());

            Complex cn2 = new Complex(20, 30);
            Console.WriteLine("Второе число: " + cn2.ToString());
            Console.WriteLine("Результат выитания: "+ Complex.Sub(cn2,cn).ToString());

            // Class
            Console.Write("\nРабота с классом\n");
            ComplexСlass num1 = new ComplexСlass(10,10);
            ComplexСlass num2 = new ComplexСlass(5, 2);

            Console.WriteLine("Первое число: " + num1.ToString());
            Console.WriteLine("Второе число: " + num2.ToString());
            Console.WriteLine("Результат деления: " + ComplexСlass.Divide(num1, num2).ToString());

            ComplexСlass num3 = new ComplexСlass();
            ComplexСlass num4 = new ComplexСlass();
            Console.WriteLine("\nСгенерировано случайное комплексное число: " + num3.ToString());
            Console.WriteLine("Сгенерировано случайное комплексное число: " + num4.ToString());
            Console.WriteLine("Что с ними сделать (sum, plus, divine)?");
            string Command = Console.ReadLine();
            switch (Command.ToLower())
            {
                case "sum": Console.WriteLine("Результат сложение: " + ComplexСlass.Sum(num3, num4).ToString());
                       
                    break;

                case "sub":
                    Console.WriteLine("Результат сложение: " + ComplexСlass.Sub(num3, num4).ToString());
                    break;

                case "divine":
                    Console.WriteLine("Результат сложение: " + ComplexСlass.Divide(num3, num4).ToString());
                    break;
                default:Console.WriteLine("Команда не найдена!");
                    break;
            }

        }

        class ComplexСlass
        {
            // Поля приватные.
            private double im;
            // По умолчанию элементы приватные, поэтому private можно не писать.
            double re;

            // Конструктор без параметров.
            public ComplexСlass()
            {
                Random rn = new Random();
                im = rn.Next(100);
                Thread.Sleep(100);
                re = rn.Next(100, 200);
            }

            // Конструктор, в котором задаем поля.    
            // Специально создадим параметр re, совпадающий с именем поля в классе.
            public ComplexСlass(double _re, double _im)
            {
                // Здесь имена не совпадают, и компилятор легко понимает, что чем является.              
                im = _im;
                // Чтобы показать, что к полю нашего класса присваивается параметр,
                // используется ключевое слово this
                // Поле параметр
                re = _re;
            }
            public ComplexСlass Plus(ComplexСlass x2)
            {
                ComplexСlass x3 = new ComplexСlass();
                x3.im = x2.im + im;
                x3.re = x2.re + re;
                return x3;
            }

            public static ComplexСlass Sub(ComplexСlass one, ComplexСlass two)
            {
                ComplexСlass ReturenedValue = new ComplexСlass(one.re - two.re, one.im - two.im);
                return ReturenedValue;

            }
            public static ComplexСlass Divide(ComplexСlass one, ComplexСlass two)
            {
                ComplexСlass ReturenedValue = new ComplexСlass(one.re / two.re, one.im / two.im);
                return ReturenedValue;

            }
            public static ComplexСlass Sum(ComplexСlass one, ComplexСlass two)
            {
                ComplexСlass ReturenedValue = new ComplexСlass(one.re + two.re, one.im + two.im);
                return ReturenedValue;

            }
            // Свойства - это механизм доступа к данным класса.
            public double Im
            {
                get { return im; }
                set
                {
                    // Для примера ограничимся только положительными числами.
                    if (value >= 0) im = value;
                }
            }
            // Специальный метод, который возвращает строковое представление данных.
            public string ToString()
            {
                return re + "+" + im + "i";
            }
        }

    }
}
