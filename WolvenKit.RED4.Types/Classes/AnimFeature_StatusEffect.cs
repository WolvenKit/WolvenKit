using static WolvenKit.RED4.Types.Enums;

namespace WolvenKit.RED4.Types
{
	[REDMeta]
	public partial class AnimFeature_StatusEffect : animAnimFeature
	{
		private CInt32 _state;
		private CFloat _duration;
		private CInt32 _variation;
		private CInt32 _direction;
		private CInt32 _impactDirection;
		private CBool _knockdown;
		private CBool _stunned;
		private CBool _playImpact;

		[Ordinal(0)] 
		[RED("state")] 
		public CInt32 State
		{
			get => GetProperty(ref _state);
			set => SetProperty(ref _state, value);
		}

		[Ordinal(1)] 
		[RED("duration")] 
		public CFloat Duration
		{
			get => GetProperty(ref _duration);
			set => SetProperty(ref _duration, value);
		}

		[Ordinal(2)] 
		[RED("variation")] 
		public CInt32 Variation
		{
			get => GetProperty(ref _variation);
			set => SetProperty(ref _variation, value);
		}

		[Ordinal(3)] 
		[RED("direction")] 
		public CInt32 Direction
		{
			get => GetProperty(ref _direction);
			set => SetProperty(ref _direction, value);
		}

		[Ordinal(4)] 
		[RED("impactDirection")] 
		public CInt32 ImpactDirection
		{
			get => GetProperty(ref _impactDirection);
			set => SetProperty(ref _impactDirection, value);
		}

		[Ordinal(5)] 
		[RED("knockdown")] 
		public CBool Knockdown
		{
			get => GetProperty(ref _knockdown);
			set => SetProperty(ref _knockdown, value);
		}

		[Ordinal(6)] 
		[RED("stunned")] 
		public CBool Stunned
		{
			get => GetProperty(ref _stunned);
			set => SetProperty(ref _stunned, value);
		}

		[Ordinal(7)] 
		[RED("playImpact")] 
		public CBool PlayImpact
		{
			get => GetProperty(ref _playImpact);
			set => SetProperty(ref _playImpact, value);
		}
	}
}
