using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Coursework
{
    /// <summary>
    /// Абстрактная фабрика (Creator)
    /// </summary>
    #region Абстрактная фабрика
    public abstract class Factory
    {
        public Factory()
        {
            CreateFile();
        }
        public abstract void CreateFile();
        public static List<string> ListOfFiles = new List<string>();
        public static void PrintListOfFiles()
        {
            Console.WriteLine("Список файлов:");
            foreach (string name in ListOfFiles)
            {
                Console.WriteLine(name);
            }
        }
        public static void FileHasBeenCreated()
        {
            int i = ListOfFiles.Count-1;
            Console.WriteLine(ListOfFiles[i] + " теперь в списке");
        }
    }
    #endregion
    /// <summary>
    ///Конкретная фабрика - создание картинок (ConcreteCreator)
    /// </summary>
    #region Фабрика картинок
    public class PictureFactory : Factory
    {
        public override void CreateFile()
        {
            IFile picture = new Picture();
            Console.WriteLine("Введите название картинки:");
            string name = picture.GetName();
            ListOfFiles.Add("Картинка "+name);
        }
    }
    #endregion
    /// <summary>
    ///Конкретная фабрика - создание текстовых файлов (ConcreteCreator)
    /// </summary>
    #region Фабрика текстовых файлов
    public class TextFileFactory : Factory
    {
        public override void CreateFile()
        {
            IFile textFile = new TextFile();
            Console.WriteLine("Введите название текстового файла:");
            string name = textFile.GetName();
            ListOfFiles.Add("Текстовый файл " + name);
        }
    }
    #endregion
    /// <summary>
    ///Конкретная фабрика - создание аудиофайлов (ConcreteCreator)
    /// </summary>
    #region Фабрика аудиофайлов
    public class AudioFileFactory : Factory
    {
        public override void CreateFile()
        {
            IFile audioFile = new AudioFile();
            Console.WriteLine("Введите название аудиофайла:");
            string name = audioFile.GetName();
            ListOfFiles.Add("Аудиофайл " + name);
        }
    }
    #endregion
    /// <summary>
    ///Конкретная фабрика - создание видеофайлов (ConcreteCreator)
    /// </summary>
    #region Фабрика видеофайлов
    public class VideoFileFactory : Factory
    {
        public override void CreateFile()
        {
            IFile videoFile = new VideoFile();
            Console.WriteLine("Введите название видеофайла:");
            string name = videoFile.GetName();
            ListOfFiles.Add("Видеофайл " + name);
        }
    }
    #endregion
}