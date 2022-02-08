using static WolvenKit.RED4.Types.Enums;

namespace WolvenKit.RED4.Types
{
	[REDMeta]
	public partial class ActivatedDeviceTransfromAnim : InteractiveDevice
	{
		[Ordinal(97)] 
		[RED("animationState")] 
		public CInt32 AnimationState
		{
			get => GetPropertyValue<CInt32>();
			set => SetPropertyValue<CInt32>(value);
		}
	}
}
