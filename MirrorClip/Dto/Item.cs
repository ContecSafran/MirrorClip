using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MirrorClip.Dto
{
    public class Item
    {
        public string name;
        public int targetX, targetY, targetW, targetH;
        public int viewX, viewY, viewW, viewH;
        public bool enable;
    }
}
