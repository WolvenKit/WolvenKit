
namespace WolvenKit.RED4.Types
{
	public partial class gameSceneTier1Data : gameSceneTierData
	{
		public gameSceneTier1Data()
		{
			Tier = Enums.GameplayTier.Tier1_FullGameplay;

			PostConstruct();
		}

		partial void PostConstruct();
	}
}
