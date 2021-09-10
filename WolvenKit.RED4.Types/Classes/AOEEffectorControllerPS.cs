using static WolvenKit.RED4.Types.Enums;

namespace WolvenKit.RED4.Types
{
	[REDMeta]
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
			TweakDBRecord = new() { Value = 87263028572 };
			TweakDBDescriptionRecord = new() { Value = 139452770593 };
			EffectsToPlay = new();
		}
	}
}
