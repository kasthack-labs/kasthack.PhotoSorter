namespace PhotoSorter
{
    using System.Collections.Generic;
    using System.IO;
    using System.Linq;
    using System.Windows.Forms;
    using System.Xml.Serialization;

    internal class SortInfo
    {
        private static readonly XmlSerializer Serializer = new(typeof(Map[]));
        private readonly Dictionary<Keys, Map> maps = new();
        private int current = -1;

        public string WorkingDirectory { get; set; }

        public ProcessFile[] Files { get; set; }

        public IList<Map> Mappings => this.maps.Values.ToArray();

        public bool ProcessKey(Keys key)
        {
            if (!this.maps.TryGetValue(key, out var t))
            {
                return false;
            }

            var f = this.Files[this.current].Path;
            File.Move(f, Path.Combine(t.Path, Path.GetFileName(f)));
            return true;
        }

        public bool AddMap(Map map)
        {
            if (!this.maps.ContainsKey(map.Key))
            {
                this.maps.Add(map.Key, map);
            }

            return true;
        }

        public void RemoveMap(Keys keys)
        {
            if (this.maps.ContainsKey(keys))
            {
                _ = this.maps.Remove(keys);
            }
        }

        public void SetActive(int ind) => this.current = ind;

        public void SaveMap(string fileName)
        {
            using var f = File.OpenWrite(fileName);
            f.SetLength(0);
            Serializer.Serialize(f, this.Mappings.ToArray());
        }

        public void LoadMap(string fileName)
        {
            using var f = File.OpenRead(fileName);
            foreach (var map in (Map[])Serializer.Deserialize(f))
            {
                this.maps.Add(map.Key, map);
            }
        }
    }
}
