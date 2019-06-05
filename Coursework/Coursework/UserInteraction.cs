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
            Console.WriteLine("* Список файлов - показать список созданных файлов");
            Console.WriteLine("* Команды - показать список доступных команд");
            Console.WriteLine("* Выход - закрыть приложение");
        }
        public void ChooseWhatToDo()
        {
            string input = Console.ReadLine();
            switch (input)
            {
                case "Картинка": case "картинка": { var newFile = new PictureFactory(); Factory.FileHasBeenCreated(); break; }
                case "Текстовый файл": case "текстовый файл": case "текст": case "Текст": case "text": { var newFile = new TextFileFactory(); Factory.FileHasBeenCreated(); break; }
                case "Аудиофайл": case "аудиофайл": case "аудио": case "Аудио": case "audio": { var newFile = new AudioFileFactory(); Factory.FileHasBeenCreated(); break; }
                case "Видеофайл": case "видеофайл": case "видео": case "Видео": case "video": { var newFile = new VideoFileFactory(); Factory.FileHasBeenCreated(); break; }
                case "Список": case "список": case "список файлов": case "Список файлов": case "файлы": case "Файлы": case "files": { Factory.PrintListOfFiles(); break; }
                case "Команды": case "команды": case "список команд": case "Список команд": case "commands": { PrintListOfCommands(); break; }
                case "Выход": case "выход": case "стоп": case "Стоп": case "stop": { Environment.Exit(0); break; }
                default: { Console.WriteLine("Такой команды не существует"); break; }
            }
            AnyMoreActions();
        }
        public void AnyMoreActions()
        {
            Console.WriteLine("Введите следующую команду:");
            ChooseWhatToDo();
        }
    }
}