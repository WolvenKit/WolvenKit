using static WolvenKit.RED4.Types.Enums;

namespace WolvenKit.RED4.Types
{
	public partial class PlayerControlDeviceData : RedBaseClass
	{
		[Ordinal(0)] 
		[RED("currentYawModifier")] 
		public CFloat CurrentYawModifier
		{
			get => GetPropertyValue<CFloat>();
			set => SetPropertyValue<CFloat>(value);
		}

		[Ordinal(1)] 
		[RED("currentPitchModifier")] 
		public CFloat CurrentPitchModifier
		{
			get => GetPropertyValue<CFloat>();
			set => SetPropertyValue<CFloat>(value);
		}

		public PlayerControlDeviceData()
		{
			PostConstruct();
		}

		partial void PostConstruct();
	}
}
