using static WolvenKit.RED4.Types.Enums;

namespace WolvenKit.RED4.Types
{
	[REDMeta]
	public partial class AnimFeature_PlayerVitals : animAnimFeature
	{
		private CInt32 _state;
		private CFloat _stateDuration;

		[Ordinal(0)] 
		[RED("state")] 
		public CInt32 State
		{
			get => GetProperty(ref _state);
			set => SetProperty(ref _state, value);
		}

		[Ordinal(1)] 
		[RED("stateDuration")] 
		public CFloat StateDuration
		{
			get => GetProperty(ref _stateDuration);
			set => SetProperty(ref _stateDuration, value);
		}
	}
}
