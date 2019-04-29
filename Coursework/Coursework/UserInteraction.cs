using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Coursework
{
    class UserInteraction
    {
        public void PrintListOfCommands()
        {
            Console.WriteLine("Список доступных команд:");
            Console.WriteLine("* Картинка - создать картинку");
            Console.WriteLine("* Текстовый файл - создать текстовый файл");
            Console.WriteLine("* Аудиофайл - создать аудиофайл");
            Console.WriteLine("* Видеофайл - создать видеофайл");
            Console.WriteLine("* Список - показать список созданных файлов");
            Console.WriteLine("* Команды - показать список доступных команд");
            Console.WriteLine("* Выход - закрыть приложение");
        }
        public void ChooseWhatToDo()
        {
            string input = Console.ReadLine();
            switch (input)
            {
                case "Картинка": { var newFile = new PictureFactory(); break; }
                case "Текстовый файл": { var newFile = new TextFileFactory(); break; }
                case "Аудиофайл": { var newFile = new AudioFileFactory(); break; }
                case "Видеофайл": { var newFile = new VideoFileFactory(); break; }
                case "Список": { Factory.PrintListOfFiles(); break; }
                case "Команды": { PrintListOfCommands(); break; }
                case "Выход": { Environment.Exit(0); break; }
                default: { Console.WriteLine("Такой команды не существует"); break; }
            }
        }
        public void AnyMoreActions()
        {
            Console.WriteLine("Введите следующую команду:");
            ChooseWhatToDo();
        }
    }
}
