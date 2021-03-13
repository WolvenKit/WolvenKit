using WolvenKit.RED4.CR2W.Reflection;
using FastMember;
using static WolvenKit.RED4.CR2W.Types.Enums;

namespace WolvenKit.RED4.CR2W.Types
{
	[REDMeta]
	public class questMultiplayerTeleportPuppetParams : CVariable
	{
		[Ordinal(0)] [RED("teleportAllPlayers")] public CBool TeleportAllPlayers { get; set; }
		[Ordinal(1)] [RED("spawnPointTag")] public CName SpawnPointTag { get; set; }
		[Ordinal(2)] [RED("destinationRef")] public gameEntityReference DestinationRef { get; set; }
		[Ordinal(3)] [RED("destinationOffset")] public Vector3 DestinationOffset { get; set; }
		[Ordinal(4)] [RED("areaNodeTriggerRef")] public gameEntityReference AreaNodeTriggerRef { get; set; }

		public questMultiplayerTeleportPuppetParams(CR2WFile cr2w, CVariable parent, string name) : base(cr2w, parent, name) { }
	}
}
