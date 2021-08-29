using static WolvenKit.RED4.Types.Enums;

namespace WolvenKit.RED4.Types
{
	[REDMeta]
	public partial class scnRewindableSectionPlaySpeedModifiers : RedBaseClass
	{
		private CFloat _forwardVeryFast;
		private CFloat _forwardFast;
		private CFloat _forwardSlow;
		private CFloat _backwardVeryFast;
		private CFloat _backwardFast;
		private CFloat _backwardSlow;

		[Ordinal(0)] 
		[RED("forwardVeryFast")] 
		public CFloat ForwardVeryFast
		{
			get => GetProperty(ref _forwardVeryFast);
			set => SetProperty(ref _forwardVeryFast, value);
		}

		[Ordinal(1)] 
		[RED("forwardFast")] 
		public CFloat ForwardFast
		{
			get => GetProperty(ref _forwardFast);
			set => SetProperty(ref _forwardFast, value);
		}

		[Ordinal(2)] 
		[RED("forwardSlow")] 
		public CFloat ForwardSlow
		{
			get => GetProperty(ref _forwardSlow);
			set => SetProperty(ref _forwardSlow, value);
		}

		[Ordinal(3)] 
		[RED("backwardVeryFast")] 
		public CFloat BackwardVeryFast
		{
			get => GetProperty(ref _backwardVeryFast);
			set => SetProperty(ref _backwardVeryFast, value);
		}

		[Ordinal(4)] 
		[RED("backwardFast")] 
		public CFloat BackwardFast
		{
			get => GetProperty(ref _backwardFast);
			set => SetProperty(ref _backwardFast, value);
		}

		[Ordinal(5)] 
		[RED("backwardSlow")] 
		public CFloat BackwardSlow
		{
			get => GetProperty(ref _backwardSlow);
			set => SetProperty(ref _backwardSlow, value);
		}
	}
}
