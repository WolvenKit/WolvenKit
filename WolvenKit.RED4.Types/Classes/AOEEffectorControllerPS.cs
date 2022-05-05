using static WolvenKit.RED4.Types.Enums;

namespace WolvenKit.RED4.Types
{
	public partial class AOEEffectorControllerPS : ActivatedDeviceControllerPS
	{
		[Ordinal(108)] 
		[RED("effectsToPlay")] 
		public CArray<CName> EffectsToPlay
		{
			get => GetPropertyValue<CArray<CName>>();
			set => SetPropertyValue<CArray<CName>>(value);
		}

		public AOEEffectorControllerPS()
		{
			DeviceState = Enums.EDeviceStatus.OFF;
			TweakDBRecord = 87263028572;
			TweakDBDescriptionRecord = 139452770593;
			EffectsToPlay = new();

			PostConstruct();
		}

		partial void PostConstruct();
	}
}
