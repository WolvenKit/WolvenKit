using static WolvenKit.RED4.Types.Enums;

namespace WolvenKit.RED4.Types
{
	public partial class ForkliftControllerPS : ScriptableDeviceComponentPS
	{
		[Ordinal(104)] 
		[RED("forkliftSetup")] 
		public ForkliftSetup ForkliftSetup
		{
			get => GetPropertyValue<ForkliftSetup>();
			set => SetPropertyValue<ForkliftSetup>(value);
		}

		[Ordinal(105)] 
		[RED("isUp")] 
		public CBool IsUp
		{
			get => GetPropertyValue<CBool>();
			set => SetPropertyValue<CBool>(value);
		}

		public ForkliftControllerPS()
		{
			DeviceName = "LocKey#1639";
			TweakDBRecord = 71902502349;
			TweakDBDescriptionRecord = 124000636758;
			ForkliftSetup = new() { ActionActivateName = "Activate", LiftingAnimationTime = 2.000000F, HasDistractionQuickhack = true };

			PostConstruct();
		}

		partial void PostConstruct();
	}
}
