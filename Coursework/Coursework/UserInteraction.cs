using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Coursework
{
    class UserInteraction
    {
        Subject subject = new Subject();
        List<string> ListOfUsers = new List<string>();
        public void ChooseWhatToDo()
        {
            string input = Console.ReadLine();
            switch (input)
            {
                case "Создать":
                case "Создать файл":
                case "Новый файл":
                case "файл":
                case "Файл":
                case "создать файл":
                case "создать":
                case "New file":
                case "File":
                case "file":
                case "new file":
                    {
                        Factory factory = null;
                        Console.WriteLine("Введите желаемый тип файла: \n-Картинка \n-Текстовый файл \n-Аудиофайл \n-Видеофайл");
                        string fileType = Console.ReadLine();
                        switch (fileType)
                        {
                            case "Картинка": case "картинка": case "Изображение": case "изображение": case "picture": case "Picture": { factory = new PictureFactory(); break; }
                            case "Текстовый файл": case "текстовый файл": case "текст": case "Текст": case "text": { factory = new TextFileFactory(); break; }
                            case "Аудиофайл": case "аудиофайл": case "аудио": case "Аудио": case "audio": { factory = new AudioFileFactory(); break; }
                            case "Видеофайл": case "видеофайл": case "видео": case "Видео": case "video": { factory = new VideoFileFactory(); break; }
                        }
                        IFile newFile = factory.CreateFile();
                        subject.FileHasBeenCreated(newFile);
                        newFile.ShowContent();
                        break;
                    }
                case "Список": case "список": case "список файлов": case "Список файлов": case "файлы": case "Файлы": case "files": { Subject.PrintListOfFiles(); break; }
                case "Команды": case "команды": case "список команд": case "Список команд": case "commands": { PrintListOfCommands(); break; }
                case "user":
                case "User":
                case "users":
                case "Users":
                case "Пользователь":
                case "Пользователи":
                case "пользователь":
                case "пользователи":
                case "юзер":
                case "юзеры":
                case "Юзер":
                case "Юзеры":
                    {
                        Console.WriteLine("* Сюздать пользователя");
                        Console.WriteLine("* Подписаться");
                        Console.WriteLine("* Отписаться");
                        Console.WriteLine("* Список пользоваетелей");
                        string userCommand = Console.ReadLine();
                        switch (userCommand)
                        {
                            case "new user":
                            case "create user":
                            case "Create user":
                            case "New user":
                            case "Создать пользователя":
                            case "создать пользователя":
                            case "новый юзер":
                            case "Новый юзер":
                                {
                                    IObserver newUser = new Observer();
                                    newUser.NewUsername();
                                    ListOfUsers.Add(newUser.Name());
                                    Console.WriteLine("Подписать пользователя на изменения списка файлов? \nДа/Нет");
                                    string answer = Console.ReadLine();
                                    if (answer == "Да") subject.Attach(newUser);
                                    else if (answer == "Нет") break;
                                    else Console.WriteLine("Команда неизвестна");
                                    break;
                                }
                            case "Подписаться": {
                                    Console.WriteLine("Выберите имя пользователя, которого хотите подписать на обновления:");
                                    PrintListOfUsers();
                                    string userName = Console.ReadLine();
                                    //subject.Attach(userName);
                                    break; }
                            case "Отписаться":
                                {
                                    Console.WriteLine("Выберите имя пользователя, которого хотите отписать от обновлений:");
                                    PrintListOfUsers();
                                    string userName = Console.ReadLine();
                                    //subject.Detach(userName);
                                    break;
                                }
                            case "Список пользователей": { PrintListOfUsers(); break; }
                            case "Выход": case "выход":  case "стоп": case "Стоп": case "stop": break;
                            default: { Console.WriteLine("Такой команды не существует"); break; }
                        }
                        break;
                    }
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
        public void PrintListOfCommands()
        {
            Console.WriteLine("Список доступных команд:");
            Console.WriteLine("* Создать файл");
            Console.WriteLine("* Список файлов - показать список созданных файлов");
            Console.WriteLine("* Команды - показать список доступных команд");
            Console.WriteLine("* Новый юзер - создать нового пользователя");
            Console.WriteLine("* Выход - закрыть приложение");
        }
        public void PrintListOfUsers()
        {
            foreach (string name in ListOfUsers)
            Console.WriteLine(name); 
        }
    }
}