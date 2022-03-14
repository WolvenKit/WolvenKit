using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using WolvenKit.RED4.Archive.Buffer;

namespace WolvenKit.RED4.Archive.IO
{
    public class CR2WListReader : IBufferReader
    {
        private MemoryStream _ms;

        public CR2WListReader(MemoryStream ms)
        {
            _ms = ms;
        }

        public EFileReadErrorCodes ReadBuffer(RedBuffer buffer, Type fileRootType)
        {
            var list = new CR2WList();
            var result = EFileReadErrorCodes.NoError;
            while (result != EFileReadErrorCodes.NoCr2w)
            {
                var reader = new CR2WReader(_ms);
                result = reader.ReadFile(out var cr2wFile, false);
                if (cr2wFile != null)
                {
                    byte[] data = _ms.ToArray().Skip(reader.Position).ToArray();
                    _ms = new MemoryStream(data);

                    list.Files.Add(cr2wFile);
                }
            }

            buffer.Data = list;

            return EFileReadErrorCodes.NoError;
        }
    }
}
