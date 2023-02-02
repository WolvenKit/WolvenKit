using static WolvenKit.RED4.Types.Enums;

namespace WolvenKit.RED4.Types
{
	public partial class questMultiplayerTeleportPuppetParams : RedBaseClass
	{
		[Ordinal(0)] 
		[RED("teleportAllPlayers")] 
		public CBool TeleportAllPlayers
		{
			get => GetPropertyValue<CBool>();
			set => SetPropertyValue<CBool>(value);
		}

		[Ordinal(1)] 
		[RED("spawnPointTag")] 
		public CName SpawnPointTag
		{
			get => GetPropertyValue<CName>();
			set => SetPropertyValue<CName>(value);
		}

		[Ordinal(2)] 
		[RED("destinationRef")] 
		public gameEntityReference DestinationRef
		{
			get => GetPropertyValue<gameEntityReference>();
			set => SetPropertyValue<gameEntityReference>(value);
		}

		[Ordinal(3)] 
		[RED("destinationOffset")] 
		public Vector3 DestinationOffset
		{
			get => GetPropertyValue<Vector3>();
			set => SetPropertyValue<Vector3>(value);
		}

		[Ordinal(4)] 
		[RED("areaNodeTriggerRef")] 
		public gameEntityReference AreaNodeTriggerRef
		{
			get => GetPropertyValue<gameEntityReference>();
			set => SetPropertyValue<gameEntityReference>(value);
		}

		public questMultiplayerTeleportPuppetParams()
		{
			DestinationRef = new() { Names = new() };
			DestinationOffset = new();
			AreaNodeTriggerRef = new() { Names = new() };

			PostConstruct();
		}

		partial void PostConstruct();
	}
}
