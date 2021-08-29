using static WolvenKit.RED4.Types.Enums;

namespace WolvenKit.RED4.Types
{
	[REDMeta]
	public partial class CMatrix : RedBaseClass
	{
		private Vector4 _x;
		private Vector4 _y;
		private Vector4 _z;
		private Vector4 _w;

		[Ordinal(0)] 
		[RED("X")] 
		public Vector4 X
		{
			get => GetProperty(ref _x);
			set => SetProperty(ref _x, value);
		}

		[Ordinal(1)] 
		[RED("Y")] 
		public Vector4 Y
		{
			get => GetProperty(ref _y);
			set => SetProperty(ref _y, value);
		}

		[Ordinal(2)] 
		[RED("Z")] 
		public Vector4 Z
		{
			get => GetProperty(ref _z);
			set => SetProperty(ref _z, value);
		}

		[Ordinal(3)] 
		[RED("W")] 
		public Vector4 W
		{
			get => GetProperty(ref _w);
			set => SetProperty(ref _w, value);
		}
	}
}
