using static WolvenKit.RED4.Types.Enums;

namespace WolvenKit.RED4.Types
{
	public partial class SurveillanceSystemControllerPS : DeviceSystemBaseControllerPS
	{
		[Ordinal(109)] 
		[RED("isRevealingEnemies")] 
		public CBool IsRevealingEnemies
		{
			get => GetPropertyValue<CBool>();
			set => SetPropertyValue<CBool>(value);
		}

		public SurveillanceSystemControllerPS()
		{
			PostConstruct();
		}

		partial void PostConstruct();
	}
}
