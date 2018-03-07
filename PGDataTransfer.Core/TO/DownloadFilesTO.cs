namespace PGDataTransfer.Core.TO
{
    public class DownloadFilesTO
    {
        public string URL { get; set; }

        public string Username { get; set; }

        public string Password { get; set; }

        public string PendingExtension { get; set; }

        public string DoneExtension { get; set; }
    }
}
