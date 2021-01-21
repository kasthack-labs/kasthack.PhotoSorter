using System.Windows.Forms;

namespace PhotoSorter
{
    public class Map
    {
        public Keys Key { get; set; }
        public string Path { get; set; }
        public override string ToString() => Key + " -> " + System.IO.Path.GetFileName(Path);
    }
}