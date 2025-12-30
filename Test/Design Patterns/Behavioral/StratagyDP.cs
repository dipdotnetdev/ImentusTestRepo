using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Test.Design_Patterns.Behavioral
{
    public interface ICompression
    {
        void CompressFolder(string fileName);
    }

    public class RARCompression : ICompression
    {
        public void CompressFolder(string fileName)
        {
            Console.WriteLine($"Compress using RAR: {fileName}");
        }
    }

    public class ZipCompression : ICompression
    {
        public void CompressFolder(string fileName)
        {
            Console.WriteLine($"Compress using Zip: {fileName}");
        }
    }

    public class CompressContext
    {
        private ICompression Compression;

        public CompressContext(ICompression Compression)
        {
                this.Compression = Compression;
        }

        public void SetStrategy(ICompression Compression)
        {
            this.Compression = Compression;
        }

        public void CreateArchive(string fileName)
        {
            Compression.CompressFolder(fileName);
        }
    }
    public class StratagyDP
    {
        static void Main3()
        {
            ICompression compression = new ZipCompression();

            CompressContext context= new CompressContext(compression);
            context.CreateArchive("Dot net design pattern");

            context.SetStrategy(new RARCompression());
            context.CreateArchive("Dot net design pattern");
        }
    }
}
