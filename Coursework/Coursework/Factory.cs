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
        public abstract IFile CreateFile();
    }
    #endregion
    /// <summary>
    ///Конкретная фабрика - создание картинок (ConcreteCreator)
    /// </summary>
    #region Фабрика картинок
    public class PictureFactory : Factory
    {
        public override IFile CreateFile()
        {
            IFile newPicture = new Picture();
            Console.WriteLine("Введите название изображения:");
            string name = newPicture.GetName();
            return newPicture;
        }
    }
    #endregion
    /// <summary>
    ///Конкретная фабрика - создание текстовых файлов (ConcreteCreator)
    /// </summary>
    #region Фабрика текстовых файлов
    public class TextFileFactory : Factory
    {
        public override IFile CreateFile()
        {
            IFile textFile = new TextFile();
            Console.WriteLine("Введите название текстового файла:");
            string name = textFile.GetName();
            return textFile;
        }
    }
    #endregion
    /// <summary>
    ///Конкретная фабрика - создание аудиофайлов (ConcreteCreator)
    /// </summary>
    #region Фабрика аудиофайлов
    public class AudioFileFactory : Factory
    {
        public override IFile CreateFile()
        {
            IFile audioFile = new AudioFile();
            Console.WriteLine("Введите название аудиофайла:");
            string name = audioFile.GetName();
            return audioFile;
        }
    }
    #endregion
    /// <summary>
    ///Конкретная фабрика - создание видеофайлов (ConcreteCreator)
    /// </summary>
    #region Фабрика видеофайлов
    public class VideoFileFactory : Factory
    {
        public override IFile CreateFile()
        {
            IFile videoFile = new VideoFile();
            Console.WriteLine("Введите название видеофайла:");
            string name = videoFile.GetName();
            return videoFile;
        }
    }
    #endregion
}