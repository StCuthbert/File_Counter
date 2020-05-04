using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;

namespace File_Counter
{
    class FileCounter
    {
        
        public int files_count { get; set; }
        public void FileCount(string path, string searchPattern)
        {
            DirectoryInfo dirinfo = new DirectoryInfo(path);

            if(dirinfo.Exists)
            {
                files_count = dirinfo.GetFiles(searchPattern).Length;
            }

        }

    }
}
