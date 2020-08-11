using System;
using System.IO;

namespace File
{
    class Program
    {
        static void Main(string[] args)
        {
            //Console.WriteLine("Hello World!");

            Console.WriteLine(FileCount("C:\\Users\\17842\\Desktop\\GamePlay\\CSharp"));
        }

        static int FileCount(string path)
        {
            int count = 0;

            // 统计file个数
            var files = Directory.GetFiles(path);
            count += files.Length;

            // 统计directory个数
            var dirs = Directory.GetDirectories(path);
            foreach(var dir in dirs)
            {
                count += FileCount(dir);    //递归统计每个子文件夹下文件数量
            }

            return count;
        }
    }
}
