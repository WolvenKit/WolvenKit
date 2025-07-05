using static WolvenKit.RED4.Types.Enums;

namespace WolvenKit.RED4.Types
{
	public partial class ForkliftControllerPS : ScriptableDeviceComponentPS
	{
		[Ordinal(107)] 
		[RED("forkliftSetup")] 
		public ForkliftSetup ForkliftSetup
		{
			get => GetPropertyValue<ForkliftSetup>();
			set => SetPropertyValue<ForkliftSetup>(value);
		}

		[Ordinal(108)] 
		[RED("isUp")] 
		public CBool IsUp
		{
			get => GetPropertyValue<CBool>();
			set => SetPropertyValue<CBool>(value);
		}

		public ForkliftControllerPS()
		{
			DeviceName = "LocKey#1639";
			TweakDBRecord = "Devices.Forklift";
			TweakDBDescriptionRecord = 124000636758;
			ForkliftSetup = new ForkliftSetup { ActionActivateName = "Activate", LiftingAnimationTime = 2.000000F, HasDistractionQuickhack = true };

			PostConstruct();
		}

		partial void PostConstruct();
	}
}
