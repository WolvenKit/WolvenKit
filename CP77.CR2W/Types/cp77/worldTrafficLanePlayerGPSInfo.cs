using System.IO;
using WolvenKit.CR2W.Reflection;
using FastMember;
using static WolvenKit.CR2W.Types.Enums;

namespace WolvenKit.CR2W.Types
{
	[REDMeta]
	public class worldTrafficLanePlayerGPSInfo : CVariable
	{
		[Ordinal(0)]  [RED("stronglyConnectedComponentId")] public CUInt16 StronglyConnectedComponentId { get; set; }
		[Ordinal(1)]  [RED("subGraphId")] public CUInt16 SubGraphId { get; set; }

		public worldTrafficLanePlayerGPSInfo(CR2WFile cr2w, CVariable parent, string name) : base(cr2w, parent, name) { }
	}
}
