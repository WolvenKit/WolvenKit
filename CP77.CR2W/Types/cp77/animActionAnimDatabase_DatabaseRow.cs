using System.IO;
using CP77.CR2W.Reflection;
using FastMember;
using static CP77.CR2W.Types.Enums;

namespace CP77.CR2W.Types
{
	[REDMeta]
	public class animActionAnimDatabase_DatabaseRow : CVariable
	{
		[Ordinal(0)]  [RED("animFeatureName")] public CName AnimFeatureName { get; set; }
		[Ordinal(1)]  [RED("animVariation")] public CInt32 AnimVariation { get; set; }
		[Ordinal(2)]  [RED("animationData")] public animActionAnimDatabase_AnimationData AnimationData { get; set; }
		[Ordinal(3)]  [RED("state")] public CInt32 State { get; set; }

		public animActionAnimDatabase_DatabaseRow(CR2WFile cr2w, CVariable parent, string name) : base(cr2w, parent, name) { }
	}
}
