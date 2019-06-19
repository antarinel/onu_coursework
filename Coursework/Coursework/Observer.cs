using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Coursework
{
    public interface IObserver
    {
        // Получает обновление от издателя
        void Update(ISubject subject);
        //Данные о подписчике
        string Name();
        void NewUsername();
    }

    public interface ISubject
    {
        // Присоединяет наблюдателя к издателю.
        void Attach(IObserver observer);

        // Отсоединяет наблюдателя от издателя.
        void Detach(IObserver observer);

        // Уведомляет всех наблюдателей о событии.
        void Notify();
    }

    
    public class Subject : ISubject
    {
        // Список подписчиков
        private List<IObserver> _observers = new List<IObserver>();

        // Методы управления подпиской.
        public void Attach(IObserver observer)
        {
            Console.WriteLine("Пользователь {0} подписался на изменения списка файлов.", observer.Name());
            this._observers.Add(observer);
        }
        public void Detach(IObserver observer)
        {
            this._observers.Remove(observer);
            Console.WriteLine("Пользователь {0} отписался от дальнейших изменений.", observer.Name());
        }
        // Запуск обновления в каждом подписчике.
        public void Notify()
        {
            foreach (var observer in _observers)
            {
                observer.Update(this);
                //Console.WriteLine(observer.Name() + " получил информацию об изменениях.");
            }
        }
        //Список файлов
        public static List<string> ListOfFiles = new List<string>();
        public static void PrintListOfFiles()
        {
            Console.WriteLine("Список файлов:");
            foreach (string name in ListOfFiles)
            {
                Console.WriteLine(name);
            }
        }
        public void FileHasBeenCreated(IFile file)
        {
            ListOfFiles.Add(file.Type() + " " + file.Name());
            Console.WriteLine(file.Type() + " " + file.Name() + " теперь в списке");
            this.Notify();
        }
    }
    public class Observer : IObserver
    {
        string userName;
        string IObserver.Name() { return userName; }
        //Метод создания новых пользователей
        void IObserver.NewUsername()
        {
            Console.WriteLine("Введите имя пользователя:");
            this.userName = Console.ReadLine();
        }
        //Метод обновления пользователей
        public void Update(ISubject subject)
        {
            Console.WriteLine("{0} получил информацию об изменениях.", userName);
        }
    }

}
