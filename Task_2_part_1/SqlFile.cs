namespace Lab_2.Task_2_part_1
{
    public class SqlFile : IFile
    {
        public string FilePath { get; set; }
        public string FileText { get; set; }
        public string LoadText() => string.Empty;
        public string SaveText() => string.Empty;
    }
}
