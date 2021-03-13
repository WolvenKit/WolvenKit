using CP77.CR2W.Reflection;
using FastMember;
using static CP77.CR2W.Types.Enums;

namespace CP77.CR2W.Types
{
	[REDMeta]
	public class gameItemID : CVariable
	{
		[Ordinal(0)] [RED("id")] public TweakDBID Id { get; set; }
		[Ordinal(1)] [RED("rngSeed")] public CUInt32 RngSeed { get; set; }
		[Ordinal(2)] [RED("uniqueCounter")] public CUInt16 UniqueCounter { get; set; }

		public gameItemID(CR2WFile cr2w, CVariable parent, string name) : base(cr2w, parent, name) { }
	}
}
