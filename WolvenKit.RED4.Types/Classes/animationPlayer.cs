using static WolvenKit.RED4.Types.Enums;

namespace WolvenKit.RED4.Types
{
	[REDMeta]
	public partial class animationPlayer : inkWidgetLogicController
	{
		private CName _animName;
		private CEnum<inkanimLoopType> _loopType;
		private CFloat _delay;
		private CBool _playInfinite;
		private CUInt32 _loopsAmount;
		private CBool _playReversed;
		private inkWidgetReference _animTarget;
		private CBool _autoPlay;
		private CHandle<inkanimProxy> _anim;

		[Ordinal(1)] 
		[RED("animName")] 
		public CName AnimName
		{
			get => GetProperty(ref _animName);
			set => SetProperty(ref _animName, value);
		}

		[Ordinal(2)] 
		[RED("loopType")] 
		public CEnum<inkanimLoopType> LoopType
		{
			get => GetProperty(ref _loopType);
			set => SetProperty(ref _loopType, value);
		}

		[Ordinal(3)] 
		[RED("delay")] 
		public CFloat Delay
		{
			get => GetProperty(ref _delay);
			set => SetProperty(ref _delay, value);
		}

		[Ordinal(4)] 
		[RED("playInfinite")] 
		public CBool PlayInfinite
		{
			get => GetProperty(ref _playInfinite);
			set => SetProperty(ref _playInfinite, value);
		}

		[Ordinal(5)] 
		[RED("loopsAmount")] 
		public CUInt32 LoopsAmount
		{
			get => GetProperty(ref _loopsAmount);
			set => SetProperty(ref _loopsAmount, value);
		}

		[Ordinal(6)] 
		[RED("playReversed")] 
		public CBool PlayReversed
		{
			get => GetProperty(ref _playReversed);
			set => SetProperty(ref _playReversed, value);
		}

		[Ordinal(7)] 
		[RED("animTarget")] 
		public inkWidgetReference AnimTarget
		{
			get => GetProperty(ref _animTarget);
			set => SetProperty(ref _animTarget, value);
		}

		[Ordinal(8)] 
		[RED("autoPlay")] 
		public CBool AutoPlay
		{
			get => GetProperty(ref _autoPlay);
			set => SetProperty(ref _autoPlay, value);
		}

		[Ordinal(9)] 
		[RED("anim")] 
		public CHandle<inkanimProxy> Anim
		{
			get => GetProperty(ref _anim);
			set => SetProperty(ref _anim, value);
		}
	}
}
