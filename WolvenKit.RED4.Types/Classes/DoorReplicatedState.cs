using static WolvenKit.RED4.Types.Enums;

namespace WolvenKit.RED4.Types
{
	[REDMeta]
	public partial class DoorReplicatedState : gameDeviceReplicatedState
	{
		private CBool _isOpen;
		private CBool _wasImmediateChange;

		[Ordinal(0)] 
		[RED("isOpen")] 
		public CBool IsOpen
		{
			get => GetProperty(ref _isOpen);
			set => SetProperty(ref _isOpen, value);
		}

		[Ordinal(1)] 
		[RED("wasImmediateChange")] 
		public CBool WasImmediateChange
		{
			get => GetProperty(ref _wasImmediateChange);
			set => SetProperty(ref _wasImmediateChange, value);
		}
	}
}
