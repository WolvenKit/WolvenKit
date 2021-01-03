using System.IO;
using WolvenKit.CR2W.Reflection;
using FastMember;
using static WolvenKit.CR2W.Types.Enums;

namespace WolvenKit.CR2W.Types
{
	[REDMeta]
	public class animAnimNode_AddSnapToTerrainIkRequest : animAnimNode_OnePoseInput
	{
		[Ordinal(0)]  [RED("animDeltaZ")] public animFloatLink AnimDeltaZ { get; set; }
		[Ordinal(1)]  [RED("hipsRequest")] public animHipsIkRequest HipsRequest { get; set; }
		[Ordinal(2)]  [RED("leftFootRequest")] public animSnapToTerrainIkRequest LeftFootRequest { get; set; }
		[Ordinal(3)]  [RED("rightFootRequest")] public animSnapToTerrainIkRequest RightFootRequest { get; set; }

		public animAnimNode_AddSnapToTerrainIkRequest(CR2WFile cr2w, CVariable parent, string name) : base(cr2w, parent, name) { }
	}
}
