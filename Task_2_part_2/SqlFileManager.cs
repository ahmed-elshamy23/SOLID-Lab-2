namespace Lab_2.Task_2_part_2
{
    public class SqlFileManager : FileManager<SqlFile>
    {
        public override void SaveTextIntoFiles()
        {
            foreach (var objFile in Files)
                if (!(objFile is ReadOnlySqlFile))
                    objFile.SaveText();
        }
    }
}
