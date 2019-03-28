using System.Collections.Generic;

namespace Tumblr.API
{
    public class Photo
    {
        public string caption { get; set; }
        public OriginalSize original_size { get; set; }
        public List<AltSize> alt_sizes { get; set; }
        public Exif exif { get; set; }
    }
}
