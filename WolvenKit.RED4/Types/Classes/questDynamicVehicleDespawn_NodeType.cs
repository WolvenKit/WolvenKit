using static WolvenKit.RED4.Types.Enums;

namespace WolvenKit.RED4.Types
{
	public partial class questDynamicVehicleDespawn_NodeType : questIDynamicSpawnSystemType
	{
		[Ordinal(0)] 
		[RED("ImmediateDespawn")] 
		public CBool ImmediateDespawn
		{
			get => GetPropertyValue<CBool>();
			set => SetPropertyValue<CBool>(value);
		}

		[Ordinal(1)] 
		[RED("waveTag")] 
		public CName WaveTag
		{
			get => GetPropertyValue<CName>();
			set => SetPropertyValue<CName>(value);
		}

		public questDynamicVehicleDespawn_NodeType()
		{
			WaveTag = "DefaultWave";

			PostConstruct();
		}

		partial void PostConstruct();
	}
}
