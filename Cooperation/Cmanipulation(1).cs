using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.IO;

namespace Cooperation
{
    class Cmanipulation
    {
        public void UpdateItem(string FileTxt, string data)
        {
            FileStream fs = new FileStream(FileTxt, FileMode.Append, FileAccess.Write);
            StreamWriter sw = new StreamWriter(fs);

            sw.Write(data);

            sw.Flush();
            sw.Close();
            fs.Close();
        }
    }
}
