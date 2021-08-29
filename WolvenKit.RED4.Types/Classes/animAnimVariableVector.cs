using static WolvenKit.RED4.Types.Enums;

namespace WolvenKit.RED4.Types
{
	[REDMeta]
	public partial class animAnimVariableVector : animAnimVariable
	{
		private CFloat _x;
		private CFloat _y;
		private CFloat _z;
		private CFloat _w;
		private Vector4 _default;
		private Vector4 _min;
		private Vector4 _max;

		[Ordinal(2)] 
		[RED("x")] 
		public CFloat X
		{
			get => GetProperty(ref _x);
			set => SetProperty(ref _x, value);
		}

		[Ordinal(3)] 
		[RED("y")] 
		public CFloat Y
		{
			get => GetProperty(ref _y);
			set => SetProperty(ref _y, value);
		}

		[Ordinal(4)] 
		[RED("z")] 
		public CFloat Z
		{
			get => GetProperty(ref _z);
			set => SetProperty(ref _z, value);
		}

		[Ordinal(5)] 
		[RED("w")] 
		public CFloat W
		{
			get => GetProperty(ref _w);
			set => SetProperty(ref _w, value);
		}

		[Ordinal(6)] 
		[RED("default")] 
		public Vector4 Default
		{
			get => GetProperty(ref _default);
			set => SetProperty(ref _default, value);
		}

		[Ordinal(7)] 
		[RED("min")] 
		public Vector4 Min
		{
			get => GetProperty(ref _min);
			set => SetProperty(ref _min, value);
		}

		[Ordinal(8)] 
		[RED("max")] 
		public Vector4 Max
		{
			get => GetProperty(ref _max);
			set => SetProperty(ref _max, value);
		}
	}
}
