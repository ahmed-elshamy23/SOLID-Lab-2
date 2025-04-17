namespace Lab_2.Task_2_part_2
{
    public class SqlFile : IFile
    {
        public string FilePath { get; set; }
        public string FileText { get; set; }
        public virtual string LoadText() => string.Empty;
        public virtual string SaveText() => string.Empty;
    }
}
