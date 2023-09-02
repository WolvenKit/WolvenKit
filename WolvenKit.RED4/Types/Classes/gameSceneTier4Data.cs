
namespace WolvenKit.RED4.Types
{
	public partial class gameSceneTier4Data : gameSceneTierDataMotionConstrained
	{
		public gameSceneTier4Data()
		{
			Tier = Enums.GameplayTier.Tier4_FPPCinematic;
			Params = new gameMotionConstrainedTierDataParams();

			PostConstruct();
		}

		partial void PostConstruct();
	}
}
