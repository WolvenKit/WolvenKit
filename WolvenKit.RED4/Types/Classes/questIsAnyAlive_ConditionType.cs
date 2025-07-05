using static WolvenKit.RED4.Types.Enums;

namespace WolvenKit.RED4.Types
{
	public partial class questIsAnyAlive_ConditionType : questIDynamicSpawnSystemConditionType
	{
		[Ordinal(0)] 
		[RED("waveTag")] 
		public CName WaveTag
		{
			get => GetPropertyValue<CName>();
			set => SetPropertyValue<CName>(value);
		}

		[Ordinal(1)] 
		[RED("inverted")] 
		public CBool Inverted
		{
			get => GetPropertyValue<CBool>();
			set => SetPropertyValue<CBool>(value);
		}

		public questIsAnyAlive_ConditionType()
		{
			WaveTag = "DefaultWave";

			PostConstruct();
		}

		partial void PostConstruct();
	}
}
