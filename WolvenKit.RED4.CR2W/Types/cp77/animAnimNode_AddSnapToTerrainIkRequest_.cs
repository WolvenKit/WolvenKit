using WolvenKit.RED4.CR2W.Reflection;
using FastMember;
using static WolvenKit.RED4.CR2W.Types.Enums;

namespace WolvenKit.RED4.CR2W.Types
{
	[REDMeta]
	public class animAnimNode_AddSnapToTerrainIkRequest_ : animAnimNode_OnePoseInput
	{
		[Ordinal(13)] [RED("animDeltaZ")] public animFloatLink AnimDeltaZ { get; set; }
		[Ordinal(14)] [RED("leftFootRequest")] public animSnapToTerrainIkRequest LeftFootRequest { get; set; }
		[Ordinal(15)] [RED("rightFootRequest")] public animSnapToTerrainIkRequest RightFootRequest { get; set; }
		[Ordinal(16)] [RED("hipsRequest")] public animHipsIkRequest HipsRequest { get; set; }

		public animAnimNode_AddSnapToTerrainIkRequest_(CR2WFile cr2w, CVariable parent, string name) : base(cr2w, parent, name) { }
	}
}
