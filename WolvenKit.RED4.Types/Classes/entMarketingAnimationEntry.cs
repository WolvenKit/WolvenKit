using static WolvenKit.RED4.Types.Enums;

namespace WolvenKit.RED4.Types
{
	[REDMeta]
	public partial class entMarketingAnimationEntry : RedBaseClass
	{
		private CName _animationName;
		private CFloat _time;
		private CFloat _frame;

		[Ordinal(0)] 
		[RED("animationName")] 
		public CName AnimationName
		{
			get => GetProperty(ref _animationName);
			set => SetProperty(ref _animationName, value);
		}

		[Ordinal(1)] 
		[RED("time")] 
		public CFloat Time
		{
			get => GetProperty(ref _time);
			set => SetProperty(ref _time, value);
		}

		[Ordinal(2)] 
		[RED("frame")] 
		public CFloat Frame
		{
			get => GetProperty(ref _frame);
			set => SetProperty(ref _frame, value);
		}
	}
}
