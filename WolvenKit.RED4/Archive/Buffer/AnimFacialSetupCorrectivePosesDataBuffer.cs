using WolvenKit.RED4.Types;

namespace WolvenKit.RED4.Archive.Buffer;

public class AnimFacialSetupCorrectivePosesDataBuffer : IParseableBuffer
{
    public IRedType? Data => null;

    public AnimFacialSetupPosesPartData Face { get; set; }
    public AnimFacialSetupPosesPartData Tongue { get; set; }
    public AnimFacialSetupPosesPartData Eyes { get; set; }
}