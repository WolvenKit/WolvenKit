using static WolvenKit.RED4.Types.Enums;

namespace WolvenKit.RED4.Types
{
	[REDMeta]
	public partial class AnimFeature_Carry : animAnimFeature
	{
		private CInt32 _state;
		private CInt32 _pickupAnimation;
		private CBool _useBothHands;
		private CBool _instant;

		[Ordinal(0)] 
		[RED("state")] 
		public CInt32 State
		{
			get => GetProperty(ref _state);
			set => SetProperty(ref _state, value);
		}

		[Ordinal(1)] 
		[RED("pickupAnimation")] 
		public CInt32 PickupAnimation
		{
			get => GetProperty(ref _pickupAnimation);
			set => SetProperty(ref _pickupAnimation, value);
		}

		[Ordinal(2)] 
		[RED("useBothHands")] 
		public CBool UseBothHands
		{
			get => GetProperty(ref _useBothHands);
			set => SetProperty(ref _useBothHands, value);
		}

		[Ordinal(3)] 
		[RED("instant")] 
		public CBool Instant
		{
			get => GetProperty(ref _instant);
			set => SetProperty(ref _instant, value);
		}
	}
}
