
namespace WolvenKit.RED4.Types
{
	public partial class gameSceneTier5Data : gameSceneTierDataMotionConstrained
	{
		public gameSceneTier5Data()
		{
			Tier = Enums.GameplayTier.Tier5_Cinematic;
			Params = new gameMotionConstrainedTierDataParams();

			PostConstruct();
		}

		partial void PostConstruct();
	}
}
