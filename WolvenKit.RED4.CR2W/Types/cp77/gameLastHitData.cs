using WolvenKit.RED4.CR2W.Reflection;
using FastMember;
using static WolvenKit.RED4.CR2W.Types.Enums;

namespace WolvenKit.RED4.CR2W.Types
{
	[REDMeta]
	public class gameLastHitData : CVariable
	{
		[Ordinal(0)] [RED("targetEntityId")] public entEntityID TargetEntityId { get; set; }
		[Ordinal(1)] [RED("hitType")] public CUInt32 HitType { get; set; }
		[Ordinal(2)] [RED("hitShapes")] public CArray<CName> HitShapes { get; set; }

		public gameLastHitData(CR2WFile cr2w, CVariable parent, string name) : base(cr2w, parent, name) { }
	}
}
