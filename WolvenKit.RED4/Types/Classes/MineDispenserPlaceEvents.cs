using static WolvenKit.RED4.Types.Enums;

namespace WolvenKit.RED4.Types
{
	public partial class MineDispenserPlaceEvents : MineDispenserEventsTransition
	{
		[Ordinal(0)] 
		[RED("spawnPosition")] 
		public Vector4 SpawnPosition
		{
			get => GetPropertyValue<Vector4>();
			set => SetPropertyValue<Vector4>(value);
		}

		[Ordinal(1)] 
		[RED("spawnNormal")] 
		public Vector4 SpawnNormal
		{
			get => GetPropertyValue<Vector4>();
			set => SetPropertyValue<Vector4>(value);
		}

		public MineDispenserPlaceEvents()
		{
			SpawnPosition = new();
			SpawnNormal = new();

			PostConstruct();
		}

		partial void PostConstruct();
	}
}
