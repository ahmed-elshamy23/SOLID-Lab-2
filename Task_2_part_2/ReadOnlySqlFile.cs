namespace Lab_2.Task_2_part_2
{
    public class ReadOnlySqlFile : SqlFile
    {
        public override string SaveText() => throw new IOException("Can't Save");
    }
}
