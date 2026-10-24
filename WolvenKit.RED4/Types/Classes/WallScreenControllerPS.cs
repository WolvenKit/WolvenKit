using static WolvenKit.RED4.Types.Enums;

namespace WolvenKit.RED4.Types
{
	public partial class WallScreenControllerPS : TVControllerPS
	{
		[Ordinal(117)] 
		[RED("isShown")] 
		public CBool IsShown
		{
			get => GetPropertyValue<CBool>();
			set => SetPropertyValue<CBool>(value);
		}

		public WallScreenControllerPS()
		{
			TweakDBRecord = "Devices.WallScreen";
			TweakDBDescriptionRecord = "device_descriptions.WallScreen";

			PostConstruct();
		}

		partial void PostConstruct();
	}
}
