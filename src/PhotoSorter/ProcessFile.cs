namespace PhotoSorter
{
    internal class ProcessFile
    {
        public ProcessFile(string path) => this.Path = path;

        public string Path { get; set; }

        public bool Deleted { get; set; }

        public override string ToString() => System.IO.Path.GetFileName(this.Path);
    }
}
