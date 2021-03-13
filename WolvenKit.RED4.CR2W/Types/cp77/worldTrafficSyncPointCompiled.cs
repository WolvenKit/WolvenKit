using WolvenKit.RED4.CR2W.Reflection;
using FastMember;
using static WolvenKit.RED4.CR2W.Types.Enums;

namespace WolvenKit.RED4.CR2W.Types
{
	[REDMeta]
	public class worldTrafficSyncPointCompiled : CVariable
	{
		[Ordinal(0)] [RED("lanes")] public CArray<worldTrafficLaneUID> Lanes { get; set; }
		[Ordinal(1)] [RED("lanePositions")] public CArray<CFloat> LanePositions { get; set; }
		[Ordinal(2)] [RED("length")] public CFloat Length { get; set; }

		public worldTrafficSyncPointCompiled(CR2WFile cr2w, CVariable parent, string name) : base(cr2w, parent, name) { }
	}
}
