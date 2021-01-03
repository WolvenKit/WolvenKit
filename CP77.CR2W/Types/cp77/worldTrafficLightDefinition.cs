using System.IO;
using WolvenKit.CR2W.Reflection;
using FastMember;
using static WolvenKit.CR2W.Types.Enums;

namespace WolvenKit.CR2W.Types
{
	[REDMeta]
	public class worldTrafficLightDefinition : CVariable
	{
		[Ordinal(0)]  [RED("extent")] public CFloat Extent { get; set; }
		[Ordinal(1)]  [RED("groupIdx")] public CUInt32 GroupIdx { get; set; }
		[Ordinal(2)]  [RED("positionOnLane")] public CFloat PositionOnLane { get; set; }
		[Ordinal(3)]  [RED("timeline")] public CArray<worldTrafficLightStage> Timeline { get; set; }

		public worldTrafficLightDefinition(CR2WFile cr2w, CVariable parent, string name) : base(cr2w, parent, name) { }
	}
}
