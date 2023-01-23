using static WolvenKit.RED4.Types.Enums;

namespace WolvenKit.RED4.Types
{
	public partial class PlayerVisionModeControllerInputListeners : RedBaseClass
	{
		[Ordinal(0)] 
		[RED("buttonHold")] 
		public CUInt32 ButtonHold
		{
			get => GetPropertyValue<CUInt32>();
			set => SetPropertyValue<CUInt32>(value);
		}

		[Ordinal(1)] 
		[RED("buttonToggle")] 
		public CUInt32 ButtonToggle
		{
			get => GetPropertyValue<CUInt32>();
			set => SetPropertyValue<CUInt32>(value);
		}

		public PlayerVisionModeControllerInputListeners()
		{
			PostConstruct();
		}

		partial void PostConstruct();
	}
}
