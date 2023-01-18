using System;

namespace WolvenKit.RED4.Archive.IO;

public interface IBufferReader
{
    public EFileReadErrorCodes ReadBuffer(RedBuffer buffer);
}
