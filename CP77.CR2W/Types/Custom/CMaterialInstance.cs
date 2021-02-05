using System.IO;
using CP77.CR2W.Reflection;
using FastMember;
using static CP77.CR2W.Types.Enums;

namespace CP77.CR2W.Types
{
	[REDMeta]
	public class CMaterialInstance : IMaterial
	{
		[Ordinal(0)]  [RED("enableMask")] public CBool EnableMask { get; set; }
		[Ordinal(1)]  [RED("audioTag")] public CName AudioTag { get; set; }
		[Ordinal(2)]  [RED("resourceVersion")] public CUInt8 ResourceVersion { get; set; }

        [Ordinal(1000)] [REDBuffer] public CArray<CVariantSizeNameType> CMaterialInstanceData { get; set; }

        public CMaterialInstance(CR2WFile cr2w, CVariable parent, string name) : base(cr2w, parent, name) { }
    }
}
