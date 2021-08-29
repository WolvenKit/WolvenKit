using static WolvenKit.RED4.Types.Enums;

namespace WolvenKit.RED4.Types
{
	[REDMeta]
	public partial class inkMargin : RedBaseClass
	{
		private CFloat _left;
		private CFloat _top;
		private CFloat _right;
		private CFloat _bottom;

		[Ordinal(0)] 
		[RED("left")] 
		public CFloat Left
		{
			get => GetProperty(ref _left);
			set => SetProperty(ref _left, value);
		}

		[Ordinal(1)] 
		[RED("top")] 
		public CFloat Top
		{
			get => GetProperty(ref _top);
			set => SetProperty(ref _top, value);
		}

		[Ordinal(2)] 
		[RED("right")] 
		public CFloat Right
		{
			get => GetProperty(ref _right);
			set => SetProperty(ref _right, value);
		}

		[Ordinal(3)] 
		[RED("bottom")] 
		public CFloat Bottom
		{
			get => GetProperty(ref _bottom);
			set => SetProperty(ref _bottom, value);
		}
	}
}
