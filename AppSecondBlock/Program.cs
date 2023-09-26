using System.ComponentModel.Design;
using System.Diagnostics;

namespace AppSecondBlock;

class AnimalNote
{
    public static void Main()
    {
        IntroText();
        Console.WriteLine("Выберите пункт меню");
        int input = Convert.ToInt16(Console.Read());
        
        Console.WriteLine(input);
        Selector(input);
    }

    private static void IntroText()
    {
        Console.WriteLine("Меню:");
        Console.WriteLine("1) Просмотреть записи о всех животных  2) Добавить новое животное");
        Console.WriteLine("3) Перевести животное в другой заповедник 4) Скоро будут новые функции");
    }
    private static void Restart()
    {
        Console.WriteLine("Хотите продолжить работу? \n");
        Console.WriteLine("1) Да 2) Нет");
        int input = Convert.ToInt16(Console.ReadKey());
        switch (input)
        {
            case '1':
                Main();
                break;
            case '2':
                Console.WriteLine("Всего доброго! Благодарим за использование нашего приложения");
                break;
            default:
                Console.WriteLine("Выберите, пожалуйста, пункт из меню");
                Restart();
                break;
        }
    }
    private static void Selector(int input)
    {
        switch (input)
        {
            case '1':
                ShowAnimals();
                Restart();
                break;
            case '2':
                AddAnimal();
                Restart();
                break;
            case '3':
                RemoveAnimal();
                Restart();
                break;
            case '4':
                Console.WriteLine("Следите за обновлениями на нашем сайте GB.ru");
                Restart();
                break;
            default:
                Console.WriteLine("Выберите, пожалуйста, пункт из меню");
                Restart();
                break;

        }
    }

    private static void RemoveAnimal()
    {
        throw new NotImplementedException();
    }

    private static void AddAnimal()
    {
        Console.WriteLine("Меню:");
        Console.WriteLine("Кого вы хотите добавить?");
        Console.WriteLine("1) Домашние питомцы: коты, собаки, хомячки");
        Console.WriteLine("2) Вьючные животные: лошади, верблюды, ослики");
        int input = Convert.ToInt16(Console.ReadKey());
        switch (input) 
        {
            case '1':
                AddPet();
                Restart();
                break;
            case '2':
                AddPackAnimal();
                Restart();
                break;
            default:
                Console.WriteLine("Выберите, пожалуйста, пункт из меню");
                Restart();
                break;
            }
    }

    private static void AddPackAnimal()
    {
        Console.WriteLine("Вьючные животные");
    }

    private static void AddPet()
    {
        Console.WriteLine("Домашние питомцы");
    }

    private static void ShowAnimals()
    {
        Console.WriteLine("Шоу животных");
    }
}