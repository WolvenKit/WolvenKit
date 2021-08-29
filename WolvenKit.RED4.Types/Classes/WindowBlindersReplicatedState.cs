using static WolvenKit.RED4.Types.Enums;

namespace WolvenKit.RED4.Types
{
	[REDMeta]
	public partial class WindowBlindersReplicatedState : gameDeviceReplicatedState
	{
		private CBool _isOpen;
		private CBool _isTilted;

		[Ordinal(0)] 
		[RED("isOpen")] 
		public CBool IsOpen
		{
			get => GetProperty(ref _isOpen);
			set => SetProperty(ref _isOpen, value);
		}

		[Ordinal(1)] 
		[RED("isTilted")] 
		public CBool IsTilted
		{
			get => GetProperty(ref _isTilted);
			set => SetProperty(ref _isTilted, value);
		}
	}
}
