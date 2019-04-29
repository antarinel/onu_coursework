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
    }
    #region Конкретные продукты - типы файлов
    /// <summary>
    /// Concrete Product - Картинки
    /// </summary>
    public class Picture : IFile
    {
        private string pictureName;
        public string GetName()
        {
            this.pictureName = Console.ReadLine();
            return pictureName;
        }
    }
    /// <summary>
    /// Concrete Product - Текстовый файл
    /// </summary>
    public class TextFile : IFile
    {
        private string textFileName;
        public string GetName()
        {
            this.textFileName = Console.ReadLine();
            return textFileName;
        }
    }
    /// <summary>
    /// Concrete Product - Аудиофайл
    /// </summary>
    public class AudioFile : IFile
    {
        private string audioFileName;
        public string GetName()
        {
            this.audioFileName = Console.ReadLine();
            return audioFileName;
        }
    }
    /// <summary>
    /// Concrete Product - Видеофайл
    /// </summary>
    public class VideoFile : IFile
    {
        private string videoFileName;
        public string GetName()
        {
            this.videoFileName = Console.ReadLine();
            return videoFileName;
        }
    }
    #endregion
}
