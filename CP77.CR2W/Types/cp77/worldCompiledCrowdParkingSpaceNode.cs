using System.IO;
using WolvenKit.CR2W.Reflection;
using FastMember;
using static WolvenKit.CR2W.Types.Enums;

namespace WolvenKit.CR2W.Types
{
	[REDMeta]
	public class worldCompiledCrowdParkingSpaceNode : worldNode
	{
		[Ordinal(0)]  [RED("crowdCreationIndex")] public CUInt32 CrowdCreationIndex { get; set; }
		[Ordinal(1)]  [RED("parkingSpaceId")] public CUInt32 ParkingSpaceId { get; set; }

		public worldCompiledCrowdParkingSpaceNode(CR2WFile cr2w, CVariable parent, string name) : base(cr2w, parent, name) { }
	}
}
