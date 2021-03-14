using WolvenKit.RED4.CR2W.Reflection;
using FastMember;
using static WolvenKit.RED4.CR2W.Types.Enums;

namespace WolvenKit.RED4.CR2W.Types
{
	[REDMeta]
	public class gamemountingMountingRequest : IScriptable
	{
		[Ordinal(0)] [RED("lowLevelMountingInfo")] public gamemountingMountingInfo LowLevelMountingInfo { get; set; }
		[Ordinal(1)] [RED("preservePositionAfterMounting")] public CBool PreservePositionAfterMounting { get; set; }
		[Ordinal(2)] [RED("mountData")] public CHandle<gameMountEventData> MountData { get; set; }

		public gamemountingMountingRequest(CR2WFile cr2w, CVariable parent, string name) : base(cr2w, parent, name) { }
	}
}
