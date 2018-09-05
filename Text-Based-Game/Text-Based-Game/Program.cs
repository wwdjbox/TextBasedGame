using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;

namespace Text_Based_Game
{
    class Program
    {
        static void Main(string[] args)
        {
            string[] filePaths = Directory.GetFiles(@"C:\Users\20111618\Documents\GitHub\TextBasedGame1\Text-Based-Game", "*.txt",
                                         SearchOption.TopDirectoryOnly);

        }
    }
}
