using static WolvenKit.RED4.Types.Enums;

namespace WolvenKit.RED4.Types
{
	[REDMeta]
	public partial class questSetCyberspacePostFX_NodeType : questIRenderFxManagerNodeType
	{
		private CBool _enabled;
		private CBool _fullScreen;
		private CBool _vfx;
		private CFloat _initialDatamosh;
		private CFloat _targetDatamosh;
		private CFloat _initialTreshold;
		private CFloat _targetTreshold;
		private CFloat _timeBlend;

		[Ordinal(0)] 
		[RED("enabled")] 
		public CBool Enabled
		{
			get => GetProperty(ref _enabled);
			set => SetProperty(ref _enabled, value);
		}

		[Ordinal(1)] 
		[RED("fullScreen")] 
		public CBool FullScreen
		{
			get => GetProperty(ref _fullScreen);
			set => SetProperty(ref _fullScreen, value);
		}

		[Ordinal(2)] 
		[RED("vfx")] 
		public CBool Vfx
		{
			get => GetProperty(ref _vfx);
			set => SetProperty(ref _vfx, value);
		}

		[Ordinal(3)] 
		[RED("initialDatamosh")] 
		public CFloat InitialDatamosh
		{
			get => GetProperty(ref _initialDatamosh);
			set => SetProperty(ref _initialDatamosh, value);
		}

		[Ordinal(4)] 
		[RED("targetDatamosh")] 
		public CFloat TargetDatamosh
		{
			get => GetProperty(ref _targetDatamosh);
			set => SetProperty(ref _targetDatamosh, value);
		}

		[Ordinal(5)] 
		[RED("initialTreshold")] 
		public CFloat InitialTreshold
		{
			get => GetProperty(ref _initialTreshold);
			set => SetProperty(ref _initialTreshold, value);
		}

		[Ordinal(6)] 
		[RED("targetTreshold")] 
		public CFloat TargetTreshold
		{
			get => GetProperty(ref _targetTreshold);
			set => SetProperty(ref _targetTreshold, value);
		}

		[Ordinal(7)] 
		[RED("timeBlend")] 
		public CFloat TimeBlend
		{
			get => GetProperty(ref _timeBlend);
			set => SetProperty(ref _timeBlend, value);
		}

		public questSetCyberspacePostFX_NodeType()
		{
			_enabled = true;
			_fullScreen = true;
			_targetDatamosh = 1.000000F;
			_targetTreshold = 0.300000F;
			_timeBlend = 3.000000F;
		}
	}
}
