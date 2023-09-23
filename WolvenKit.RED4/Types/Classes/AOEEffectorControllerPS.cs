using static WolvenKit.RED4.Types.Enums;

namespace WolvenKit.RED4.Types
{
	public partial class AOEEffectorControllerPS : ActivatedDeviceControllerPS
	{
		[Ordinal(111)] 
		[RED("effectsToPlay")] 
		public CArray<CName> EffectsToPlay
		{
			get => GetPropertyValue<CArray<CName>>();
			set => SetPropertyValue<CArray<CName>>(value);
		}

		public AOEEffectorControllerPS()
		{
			PostConstruct();
		}

		partial void PostConstruct();
	}
}
