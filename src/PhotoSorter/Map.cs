namespace PhotoSorter
{
    using System.Windows.Forms;

    public class Map
    {
        public Keys Key { get; set; }

        public string Path { get; set; }

        public override string ToString() => this.Key + " -> " + System.IO.Path.GetFileName(this.Path);
    }
}