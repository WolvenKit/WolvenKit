using WolvenKit.RED4.CR2W.Reflection;
using FastMember;
using static WolvenKit.RED4.CR2W.Types.Enums;

namespace WolvenKit.RED4.CR2W.Types
{
	[REDMeta]
	public class questMultiplayerTeleportPuppetParams : CVariable
	{
		private CBool _teleportAllPlayers;
		private CName _spawnPointTag;
		private gameEntityReference _destinationRef;
		private Vector3 _destinationOffset;
		private gameEntityReference _areaNodeTriggerRef;

		[Ordinal(0)] 
		[RED("teleportAllPlayers")] 
		public CBool TeleportAllPlayers
		{
			get => GetProperty(ref _teleportAllPlayers);
			set => SetProperty(ref _teleportAllPlayers, value);
		}

		[Ordinal(1)] 
		[RED("spawnPointTag")] 
		public CName SpawnPointTag
		{
			get => GetProperty(ref _spawnPointTag);
			set => SetProperty(ref _spawnPointTag, value);
		}

		[Ordinal(2)] 
		[RED("destinationRef")] 
		public gameEntityReference DestinationRef
		{
			get => GetProperty(ref _destinationRef);
			set => SetProperty(ref _destinationRef, value);
		}

		[Ordinal(3)] 
		[RED("destinationOffset")] 
		public Vector3 DestinationOffset
		{
			get => GetProperty(ref _destinationOffset);
			set => SetProperty(ref _destinationOffset, value);
		}

		[Ordinal(4)] 
		[RED("areaNodeTriggerRef")] 
		public gameEntityReference AreaNodeTriggerRef
		{
			get => GetProperty(ref _areaNodeTriggerRef);
			set => SetProperty(ref _areaNodeTriggerRef, value);
		}

		public questMultiplayerTeleportPuppetParams(CR2WFile cr2w, CVariable parent, string name) : base(cr2w, parent, name) { }
	}
}
