using static WolvenKit.RED4.Types.Enums;

namespace WolvenKit.RED4.Types
{
	[REDMeta]
	public partial class gameprojectileVelocityParams : RedBaseClass
	{
		private CFloat _xFactor;
		private CFloat _yFactor;
		private CFloat _zFactor;

		[Ordinal(0)] 
		[RED("xFactor")] 
		public CFloat XFactor
		{
			get => GetProperty(ref _xFactor);
			set => SetProperty(ref _xFactor, value);
		}

		[Ordinal(1)] 
		[RED("yFactor")] 
		public CFloat YFactor
		{
			get => GetProperty(ref _yFactor);
			set => SetProperty(ref _yFactor, value);
		}

		[Ordinal(2)] 
		[RED("zFactor")] 
		public CFloat ZFactor
		{
			get => GetProperty(ref _zFactor);
			set => SetProperty(ref _zFactor, value);
		}
	}
}
