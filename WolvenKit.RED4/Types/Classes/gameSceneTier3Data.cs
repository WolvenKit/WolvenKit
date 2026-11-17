using static WolvenKit.RED4.Types.Enums;

namespace WolvenKit.RED4.Types
{
	public partial class gameSceneTier3Data : gameSceneTierDataMotionConstrained
	{
		[Ordinal(4)] 
		[RED("cameraSettings")] 
		public gameTier3CameraSettings CameraSettings
		{
			get => GetPropertyValue<gameTier3CameraSettings>();
			set => SetPropertyValue<gameTier3CameraSettings>(value);
		}

		public gameSceneTier3Data()
		{
			Tier = Enums.GameplayTier.Tier3_LimitedGameplay;
			Params = new gameMotionConstrainedTierDataParams();
			CameraSettings = new gameTier3CameraSettings();

			PostConstruct();
		}

		partial void PostConstruct();
	}
}
