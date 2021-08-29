using static WolvenKit.RED4.Types.Enums;

namespace WolvenKit.RED4.Types
{
	[REDMeta]
	public partial class gameCyberspacePixelsortEffectParams : RedBaseClass
	{
		private CBool _fullscreen;
		private CBool _vfx;
		private CFloat _initialDatamosh;
		private CFloat _targetDatamosh;
		private CFloat _initialIntensity;
		private CFloat _targetIntensity;
		private CFloat _timeBlend;

		[Ordinal(0)] 
		[RED("fullscreen")] 
		public CBool Fullscreen
		{
			get => GetProperty(ref _fullscreen);
			set => SetProperty(ref _fullscreen, value);
		}

		[Ordinal(1)] 
		[RED("vfx")] 
		public CBool Vfx
		{
			get => GetProperty(ref _vfx);
			set => SetProperty(ref _vfx, value);
		}

		[Ordinal(2)] 
		[RED("initialDatamosh")] 
		public CFloat InitialDatamosh
		{
			get => GetProperty(ref _initialDatamosh);
			set => SetProperty(ref _initialDatamosh, value);
		}

		[Ordinal(3)] 
		[RED("targetDatamosh")] 
		public CFloat TargetDatamosh
		{
			get => GetProperty(ref _targetDatamosh);
			set => SetProperty(ref _targetDatamosh, value);
		}

		[Ordinal(4)] 
		[RED("initialIntensity")] 
		public CFloat InitialIntensity
		{
			get => GetProperty(ref _initialIntensity);
			set => SetProperty(ref _initialIntensity, value);
		}

		[Ordinal(5)] 
		[RED("targetIntensity")] 
		public CFloat TargetIntensity
		{
			get => GetProperty(ref _targetIntensity);
			set => SetProperty(ref _targetIntensity, value);
		}

		[Ordinal(6)] 
		[RED("timeBlend")] 
		public CFloat TimeBlend
		{
			get => GetProperty(ref _timeBlend);
			set => SetProperty(ref _timeBlend, value);
		}
	}
}
