using static WolvenKit.RED4.Types.Enums;

namespace WolvenKit.RED4.Types
{
	public partial class questDynamicVehicleDespawnAll_NodeType : questIDynamicSpawnSystemType
	{
		[Ordinal(0)] 
		[RED("ImmediateDespawn")] 
		public CBool ImmediateDespawn
		{
			get => GetPropertyValue<CBool>();
			set => SetPropertyValue<CBool>(value);
		}

		public questDynamicVehicleDespawnAll_NodeType()
		{
			PostConstruct();
		}

		partial void PostConstruct();
	}
}
