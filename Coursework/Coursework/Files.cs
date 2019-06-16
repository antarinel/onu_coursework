using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Coursework
{
    /// <summary>
    /// Product
    /// </summary>
    public interface IFile
    {
        string Type();
        string GetName();
        string Name();
        void ShowContent();
    }
    #region Конкретные продукты - типы файлов
    /// <summary>
    /// Concrete Product - Картинки
    /// </summary>
    public class Picture : IFile
    {
        private string type;
        string IFile.Type()
        {
            this.type = "Изображение";
            return type;
        }
        private string pictureName;
        string IFile.GetName()
        {
            this.pictureName = Console.ReadLine();
            return pictureName;
        }
        string IFile.Name() { return pictureName; }
        void IFile.ShowContent()
        {
            Console.WriteLine("*** Изображение ***");
        }
    }
    /// <summary>
    /// Concrete Product - Текстовый файл
    /// </summary>
    public class TextFile : IFile
    {

        private string type;
        string IFile.Type()
        {
            this.type = "Текстовый файл";
            return type;
        }
        private string textFileName;
        string IFile.GetName()
        {
            this.textFileName = Console.ReadLine();
            return textFileName;
        }
        string IFile.Name() { return textFileName; }
        void IFile.ShowContent()
        {
            Console.WriteLine("Данный файл содержит текст.");
        }
    }
    /// <summary>
    /// Concrete Product - Аудиофайл
    /// </summary>
    public class AudioFile : IFile
    {
        private string type;
        string IFile.Type()
        {
            this.type = "Аудиофайл";
            return type;
        }
        private string audioFileName;
        string IFile.GetName()
        {
            this.audioFileName = Console.ReadLine();
            return audioFileName;
        }
        string IFile.Name() { return audioFileName; }
        void IFile.ShowContent()
        {
            Console.WriteLine("***Звучит музыка***");
        }
    }
    /// <summary>
    /// Concrete Product - Видеофайл
    /// </summary>
    public class VideoFile : IFile
    {
        private string type;
        string IFile.Type()
        {
            this.type = "Видеофайл";
            return type;
        }
        private string videoFileName;
        string IFile.GetName()
        {
            this.videoFileName = Console.ReadLine();
            return videoFileName;
        }
        string IFile.Name() { return videoFileName; }
        void IFile.ShowContent()
        {
            Console.WriteLine("***Показывается видеоряд***");
        }
    }
    #endregion
}