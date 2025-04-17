using System.Text;

namespace Lab_2.Task_2_part_1
{
    public abstract class FileManager<T> where T : IFile
    {
        public List<T> Files { get; set; }
        public virtual string GetTextFromFiles()
        {
            StringBuilder objStrBuilder = new StringBuilder();
            foreach (var objFile in Files)
                objStrBuilder.Append(objFile.LoadText());
            return objStrBuilder.ToString();
        }
        public virtual void SaveTextIntoFiles()
        {
            foreach (var objFile in Files)
                objFile.SaveText();
        }
    }
}