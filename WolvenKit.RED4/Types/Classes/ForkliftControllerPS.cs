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
			TweakDBDescriptionRecord = "device_descriptions.Forklift";
			ForkliftSetup = new ForkliftSetup();

			PostConstruct();
		}

		partial void PostConstruct();
	}
}
