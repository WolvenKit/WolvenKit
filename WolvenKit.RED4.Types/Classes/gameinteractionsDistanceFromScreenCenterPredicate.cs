using static WolvenKit.RED4.Types.Enums;

namespace WolvenKit.RED4.Types
{
	[REDMeta]
	public partial class gameinteractionsDistanceFromScreenCenterPredicate : gameinteractionsIPredicateType
	{
		private CFloat _height;
		private CFloat _width;
		private CFloat _curvature;
		private CFloat _maxPriorityBoundsFactor;

		[Ordinal(0)] 
		[RED("height")] 
		public CFloat Height
		{
			get => GetProperty(ref _height);
			set => SetProperty(ref _height, value);
		}

		[Ordinal(1)] 
		[RED("width")] 
		public CFloat Width
		{
			get => GetProperty(ref _width);
			set => SetProperty(ref _width, value);
		}

		[Ordinal(2)] 
		[RED("curvature")] 
		public CFloat Curvature
		{
			get => GetProperty(ref _curvature);
			set => SetProperty(ref _curvature, value);
		}

		[Ordinal(3)] 
		[RED("maxPriorityBoundsFactor")] 
		public CFloat MaxPriorityBoundsFactor
		{
			get => GetProperty(ref _maxPriorityBoundsFactor);
			set => SetProperty(ref _maxPriorityBoundsFactor, value);
		}

		public gameinteractionsDistanceFromScreenCenterPredicate()
		{
			_height = 1.000000F;
			_width = 1.000000F;
			_curvature = 1.000000F;
		}
	}
}
