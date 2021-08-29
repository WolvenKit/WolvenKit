using static WolvenKit.RED4.Types.Enums;

namespace WolvenKit.RED4.Types
{
	[REDMeta]
	public partial class ActivatedDeviceTransfromAnim : InteractiveDevice
	{
		private CInt32 _animationState;

		[Ordinal(97)] 
		[RED("animationState")] 
		public CInt32 AnimationState
		{
			get => GetProperty(ref _animationState);
			set => SetProperty(ref _animationState, value);
		}
	}
}
