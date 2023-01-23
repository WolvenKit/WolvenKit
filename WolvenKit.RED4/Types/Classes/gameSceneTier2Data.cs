using static WolvenKit.RED4.Types.Enums;

namespace WolvenKit.RED4.Types
{
	public partial class gameSceneTier2Data : gameSceneTierData
	{
		[Ordinal(3)] 
		[RED("walkType")] 
		public CEnum<Tier2WalkType> WalkType
		{
			get => GetPropertyValue<CEnum<Tier2WalkType>>();
			set => SetPropertyValue<CEnum<Tier2WalkType>>(value);
		}

		public gameSceneTier2Data()
		{
			Tier = Enums.GameplayTier.Tier2_StagedGameplay;

			PostConstruct();
		}

		partial void PostConstruct();
	}
}
