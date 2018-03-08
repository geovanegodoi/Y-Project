namespace PGDataTransfer.Core.TO
{
    public class FileTO
    {
        public string Name { get; set; }

        public string Extension { get; set; }

        public string Path { get; set; }

        public int Size { get; set; }

        public FileHeaderTO Header { get; set; }

        public FileContentTO Content { get; set; }
    }
}
