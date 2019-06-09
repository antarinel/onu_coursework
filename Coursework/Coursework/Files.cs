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
        string GetName();
        void ShowContent();
    }
    #region Конкретные продукты - типы файлов
    /// <summary>
    /// Concrete Product - Картинки
    /// </summary>
    public class Picture : IFile
    {
        private string pictureName;
        string IFile.GetName()
        {
            this.pictureName = Console.ReadLine();
            return pictureName;
        }
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
        private string textFileName;
        string IFile.GetName()
        {
            this.textFileName = Console.ReadLine();
            return textFileName;
        }
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
        private string audioFileName;
        string IFile.GetName()
        {
            this.audioFileName = Console.ReadLine();
            return audioFileName;
        }
        void IFile.ShowContent()
        {
            Console.WriteLine("Звук /n∞∞∞∞∞∞∞");
        }
    }
    /// <summary>
    /// Concrete Product - Видеофайл
    /// </summary>
    public class VideoFile : IFile
    {
        private string videoFileName;
        string IFile.GetName()
        {
            this.videoFileName = Console.ReadLine();
            return videoFileName;
        }
        void IFile.ShowContent()
        {
            Console.WriteLine("***Показывается видеоряд***");
        }
    }
    #endregion
}