using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace CompressBold2CodeChallenge
{
    public interface ICompression <T>
    {
        byte[] Compress(T source);
        string Decompress(byte[] compressed);
    }
}
