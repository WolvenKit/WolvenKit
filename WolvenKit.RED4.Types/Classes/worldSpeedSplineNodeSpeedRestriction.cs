using static WolvenKit.RED4.Types.Enums;

namespace WolvenKit.RED4.Types
{
	[REDMeta]
	public partial class worldSpeedSplineNodeSpeedRestriction : RedBaseClass
	{
		private CFloat _speed;
		private CFloat _from;
		private CFloat _adjustTime;

		[Ordinal(0)] 
		[RED("speed")] 
		public CFloat Speed
		{
			get => GetProperty(ref _speed);
			set => SetProperty(ref _speed, value);
		}

		[Ordinal(1)] 
		[RED("from")] 
		public CFloat From
		{
			get => GetProperty(ref _from);
			set => SetProperty(ref _from, value);
		}

		[Ordinal(2)] 
		[RED("adjustTime")] 
		public CFloat AdjustTime
		{
			get => GetProperty(ref _adjustTime);
			set => SetProperty(ref _adjustTime, value);
		}
	}
}
