using System;
using System.Collections.Generic;
using System.Text;

namespace Example
{
    internal class Program
    {
        static void Main()
        {
            
       
            Console.WriteLine("Введите сумму $:");
                 string uname = Console.ReadLine();
            Console.WriteLine("Сколько вы внесли :" + uname+"$");
                 double name = Convert.ToInt32(uname);
            Console.WriteLine("Курс сщсталяет 60 руб.");
            Console.WriteLine("перевод в руб:" + (name=name*60)+ "руб"); 



            if (name <= 500) 
            {
                Console.WriteLine("комиссия составляет 8 руб:" );
                Console.WriteLine("все что осталось после комиссии :" + (name - 48) + "руб"); //48 это комиссия от 8  
            }
            else
            {
                Console.WriteLine("комиссия составляет 0,37% руб:");
                Console.WriteLine("все что осталось после комиссии " + (name - 2.22) + "руб");//2.22 это комиссия от 0.037%  
            }
                Console.WriteLine("Спасибо что использовал наш терминал Котик (>^_^)> <(^_^<) ");

















        } 
        
    }
}
