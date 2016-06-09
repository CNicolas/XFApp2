using System;
using System.IO;
using Xamarin.Forms;
using XFApp2.Droid.Services;
using XFApp2.Services;

[assembly: Dependency(typeof(SaveAndLoadService))]
namespace XFApp2.Droid.Services
{
    public class SaveAndLoadService : ISaveAndLoadService
    {
        public void SaveText(string filename, string text)
        {
            var documentsPath = Environment.GetFolderPath(Environment.SpecialFolder.Personal);
            var filePath = Path.Combine(documentsPath, filename);
            File.WriteAllText(filePath, text);
        }
        public string LoadText(string filename)
        {
            var documentsPath = Environment.GetFolderPath(Environment.SpecialFolder.Personal);
            var filePath = Path.Combine(documentsPath, filename);
            return File.ReadAllText(filePath);
        }
    }
}