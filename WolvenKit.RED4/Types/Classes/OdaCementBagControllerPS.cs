using static WolvenKit.RED4.Types.Enums;

namespace WolvenKit.RED4.Types
{
	public partial class OdaCementBagControllerPS : ScriptableDeviceComponentPS
	{
		[Ordinal(107)] 
		[RED("cementEffectCooldown")] 
		public CFloat CementEffectCooldown
		{
			get => GetPropertyValue<CFloat>();
			set => SetPropertyValue<CFloat>(value);
		}

		public OdaCementBagControllerPS()
		{
			DeviceName = "LocKey#17265";
			TweakDBRecord = "Devices.CementContainer";
			TweakDBDescriptionRecord = "device_descriptions.CementContainer";

			PostConstruct();
		}

		partial void PostConstruct();
	}
}
