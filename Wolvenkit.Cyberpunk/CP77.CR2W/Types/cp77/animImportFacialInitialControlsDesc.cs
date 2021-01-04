using System.IO;
using CP77.CR2W.Reflection;
using FastMember;
using static CP77.CR2W.Types.Enums;

namespace CP77.CR2W.Types
{
	[REDMeta]
	public class animImportFacialInitialControlsDesc : CVariable
	{
		[Ordinal(0)]  [RED("transformIds")] public CArray<CUInt16> TransformIds { get; set; }
		[Ordinal(1)]  [RED("transformNames")] public CArray<CName> TransformNames { get; set; }
		[Ordinal(2)]  [RED("transformRegions")] public CArray<CUInt8> TransformRegions { get; set; }

		public animImportFacialInitialControlsDesc(CR2WFile cr2w, CVariable parent, string name) : base(cr2w, parent, name) { }
	}
}
