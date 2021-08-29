using static WolvenKit.RED4.Types.Enums;

namespace WolvenKit.RED4.Types
{
	[REDMeta]
	public partial class animAnimFeature_AIAction : animAnimFeature
	{
		private CInt32 _state;
		private CInt32 _animVariation;
		private CFloat _stateDuration;
		private CFloat _direction;

		[Ordinal(0)] 
		[RED("state")] 
		public CInt32 State
		{
			get => GetProperty(ref _state);
			set => SetProperty(ref _state, value);
		}

		[Ordinal(1)] 
		[RED("animVariation")] 
		public CInt32 AnimVariation
		{
			get => GetProperty(ref _animVariation);
			set => SetProperty(ref _animVariation, value);
		}

		[Ordinal(2)] 
		[RED("stateDuration")] 
		public CFloat StateDuration
		{
			get => GetProperty(ref _stateDuration);
			set => SetProperty(ref _stateDuration, value);
		}

		[Ordinal(3)] 
		[RED("direction")] 
		public CFloat Direction
		{
			get => GetProperty(ref _direction);
			set => SetProperty(ref _direction, value);
		}
	}
}
