using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Windows.Forms;
using System.Xml.Serialization;

namespace PhotoSorter {
    class SortInfo {
        private static readonly XmlSerializer Serializer = new XmlSerializer( typeof(Map[]) );
        private int _current = -1;
        private readonly Dictionary<Keys, Map> _maps= new Dictionary<Keys, Map>();
        public string WorkingDirectory { get; set; }
        public ProcessFile[] Files { get; set; }

        public IList<Map> Mappings {
            get {
                return _maps.Values.ToArray();
            }
        }

        public bool ProcessKey(Keys key) {
            Map t;
            if (!_maps.TryGetValue( key, out t ))
                return false;
            var f = Files[ _current ].Path;
            File.Move( f, Path.Combine( t.Path, Path.GetFileName(f) ) );
            return true;
        }

        public bool AddMap( Map map ) {
            if (!_maps.ContainsKey( map.Key ))
                _maps.Add( map.Key, map );
            return true;
        }

        public void RemoveMap( Keys keys ) {
            if ( _maps.ContainsKey( keys ) )
                _maps.Remove( keys );
        }

        public void SetActive( int ind ) {
            _current = ind;
        }

        public void SaveMap( string fileName ) {
            using (var f = File.OpenWrite(fileName)) { 
                f.SetLength( 0 );
                Serializer.Serialize( f, Mappings.ToArray() );
            }
        }

        public void LoadMap( string fileName ) {
            using ( var f = File.OpenRead( fileName ) )
                foreach ( var map in (Map[])Serializer.Deserialize( f ) )
                    _maps.Add( map.Key, map );
        }
    }
}