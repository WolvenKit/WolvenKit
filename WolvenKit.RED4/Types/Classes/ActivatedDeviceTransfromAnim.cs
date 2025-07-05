using static WolvenKit.RED4.Types.Enums;

namespace WolvenKit.RED4.Types
{
	public partial class ActivatedDeviceTransfromAnim : InteractiveDevice
	{
		[Ordinal(98)] 
		[RED("animationState")] 
		public CInt32 AnimationState
		{
			get => GetPropertyValue<CInt32>();
			set => SetPropertyValue<CInt32>(value);
		}

		public ActivatedDeviceTransfromAnim()
		{
			PostConstruct();
		}

		partial void PostConstruct();
	}
}
