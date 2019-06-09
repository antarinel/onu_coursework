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
            Console.WriteLine("* Создать файл");
            Console.WriteLine("* Список файлов - показать список созданных файлов");
            Console.WriteLine("* Команды - показать список доступных команд");
            Console.WriteLine("* Выход - закрыть приложение");
        }
        public void ChooseWhatToDo()
        {
            string input = Console.ReadLine();
            switch (input)
            {
                case "Создать": case "Создать файл": case "Новый файл": case "файл": case "Файл": case "создать файл": case "создать":
                case "New file": case "File": case "file": case "new file": {
                        Factory factory = null;
                        Console.WriteLine("Введите желаемый тип файла: \n-Картинка \n-Текстовый файл \n-Аудиофайл \n-Видеофайл");
                        string fileType = Console.ReadLine();
                        switch (fileType)
                        {
                            case "Картинка": case "картинка": { factory = new PictureFactory();  break; }
                            case "Текстовый файл": case "текстовый файл": case "текст": case "Текст": case "text": { factory = new TextFileFactory();  break; }
                            case "Аудиофайл": case "аудиофайл": case "аудио": case "Аудио": case "audio": { factory = new AudioFileFactory(); break; }
                            case "Видеофайл": case "видеофайл": case "видео": case "Видео": case "video": { factory = new VideoFileFactory(); break; }
                        }
                        IFile newFile = factory.CreateFile();
                        newFile.ShowContent();
                        Factory.FileHasBeenCreated();
                        break;
                    }
                case "Список": case "список": case "список файлов": case "Список файлов": case "файлы": case "Файлы": case "files": { Factory.PrintListOfFiles(); break; }
                case "Команды": case "команды": case "список команд": case "Список команд": case "commands": { PrintListOfCommands(); break; }
                case "Выход": case "выход": case "стоп": case "Стоп": case "stop": { Environment.Exit(0); break; }
                default: { Console.WriteLine("Такой команды не существует"); break; }
            }
            AnyMoreActions();
        }
        public void AnyMoreActions()
        {
            Console.WriteLine("-----------------------------------");
            Console.WriteLine("Введите следующую команду:");
            ChooseWhatToDo();
        }
    }
}