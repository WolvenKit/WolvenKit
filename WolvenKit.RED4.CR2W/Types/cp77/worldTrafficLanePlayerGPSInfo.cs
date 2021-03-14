using WolvenKit.RED4.CR2W.Reflection;
using FastMember;
using static WolvenKit.RED4.CR2W.Types.Enums;

namespace WolvenKit.RED4.CR2W.Types
{
	[REDMeta]
	public class worldTrafficLanePlayerGPSInfo : CVariable
	{
		[Ordinal(0)] [RED("subGraphId")] public CUInt16 SubGraphId { get; set; }
		[Ordinal(1)] [RED("stronglyConnectedComponentId")] public CUInt16 StronglyConnectedComponentId { get; set; }

		public worldTrafficLanePlayerGPSInfo(CR2WFile cr2w, CVariable parent, string name) : base(cr2w, parent, name) { }
	}
}
