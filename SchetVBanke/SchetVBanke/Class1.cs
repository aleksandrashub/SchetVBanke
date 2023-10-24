using System;
using System.Collections.Generic;
using System.Diagnostics.Eventing.Reader;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SchetBanka
{
    public class SchetVBanke
    {

        private int nom;
        private string name;
        private float sum;

        public void choose(int otvet)
        {
            switch (otvet)
            {
                case 1:
                    otk(this.nom, this.name, this.sum);
                    break;
                case 2:
                    output();
                    break;
                case 3:
                    dob(this.sum);
                    break;
                case 4:
                    umen(this.sum);
                    break;
                case 5:
                    obnul();
                    break;


            }

        }
        public void choose(SchetVBanke schet, int chosen)
        {
            switch (chosen)
            {
                case 6:
                    if (this.nom != null && schet.nom != null)
                    {
                        perenos(schet);
                    }
                    else 
                    {
                        Console.WriteLine("Ошибка, убедитесь, что оба счета открыты");
                    }

                    break;

            }

        }

        private void otk(int nom, string name, float sum)
        {
            Console.WriteLine("Введите ФИО: ");
            this.name = Console.ReadLine();
            Console.WriteLine("Введите номер счета: ");
            this.nom = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("Введите сумму, которую хотите перевести на счет: ");
            this.sum = Convert.ToInt32(Console.ReadLine());

        }

        private void output()
        {
            Console.WriteLine("Информация о счете: \n Имя, на которое зарегистрирован счет: " + this.name + "\n Номер счета: " + this.nom + "\n Сумма на счету: " + this.sum);

        }

        private void dob(float sum)
        {
            Console.WriteLine("Введите сумму, которую хотите положить на счет: ");
            float top = float.Parse(Console.ReadLine());
            this.sum += top;
            Console.WriteLine("Новая сумма на вашем счету: " + this.sum);

        }


        private void umen(float sum)
        {
            Console.WriteLine("Введите сумму, которую хотите снять со счета: ");
            float umen = float.Parse(Console.ReadLine());
            this.sum -= umen;
            Console.WriteLine("Новая сумма на вашем счету: " + this.sum);

        }

        private void obnul()
        {
            this.sum = 0;
            Console.WriteLine("Ваш счет: 0");


        }

        private void perenos(SchetVBanke schet)
        {
           

            if (this.name != null && schet.name != null)
            {
                Console.WriteLine("С какого счета хотите перевести? Введите его номер nom");
                int otvet = Convert.ToInt32(Console.ReadLine());
                if (otvet == this.nom)
                {
                    Console.WriteLine("Какую сумму?");
                    float summa = float.Parse(Console.ReadLine());
                    schet.sum += summa;
                    this.sum -= summa;
                    Console.WriteLine("Новая сумма счета " + this.nom + " = " + this.sum + "\n Новая сумма счета " + schet.nom + " = " + schet.sum);

                }
                else if (otvet == schet.nom)
                {
                    Console.WriteLine("Какую сумму?");
                    float summa = float.Parse(Console.ReadLine());
                    this.sum += summa;
                    schet.sum -= summa;
                    Console.WriteLine("Новая сумма счета " + this.nom + " = " + this.sum + "\n Новая сумма счета " + schet.nom + " = " + schet.sum);

                }
                else
                {
                    Console.WriteLine("Такого счета у вас нет");

                }




            }
            else
            {
                Console.WriteLine("Убедитесь, что оба счета открыты");
            
            }
            

        }




    }
}


