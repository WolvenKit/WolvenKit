using static WolvenKit.RED4.Types.Enums;

namespace WolvenKit.RED4.Types
{
	public partial class SurveillanceSystemControllerPS : DeviceSystemBaseControllerPS
	{
		[Ordinal(106)] 
		[RED("isRevealingEnemies")] 
		public CBool IsRevealingEnemies
		{
			get => GetPropertyValue<CBool>();
			set => SetPropertyValue<CBool>(value);
		}

		public SurveillanceSystemControllerPS()
		{
			DeviceName = "LocKey#50770";
			TweakDBRecord = 115663064038;
			TweakDBDescriptionRecord = 164957373923;

			PostConstruct();
		}

		partial void PostConstruct();
	}
}
