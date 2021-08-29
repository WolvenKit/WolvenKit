using static WolvenKit.RED4.Types.Enums;

namespace WolvenKit.RED4.Types
{
	[REDMeta]
	public partial class Vector3 : RedBaseClass
	{
		private CFloat _x;
		private CFloat _y;
		private CFloat _z;

		[Ordinal(0)] 
		[RED("X")] 
		public CFloat X
		{
			get => GetProperty(ref _x);
			set => SetProperty(ref _x, value);
		}

		[Ordinal(1)] 
		[RED("Y")] 
		public CFloat Y
		{
			get => GetProperty(ref _y);
			set => SetProperty(ref _y, value);
		}

		[Ordinal(2)] 
		[RED("Z")] 
		public CFloat Z
		{
			get => GetProperty(ref _z);
			set => SetProperty(ref _z, value);
		}
	}
}
