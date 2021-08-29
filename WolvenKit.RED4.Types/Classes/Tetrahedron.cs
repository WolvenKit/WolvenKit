using static WolvenKit.RED4.Types.Enums;

namespace WolvenKit.RED4.Types
{
	[REDMeta]
	public partial class Tetrahedron : RedBaseClass
	{
		private Vector4 _point1;
		private Vector4 _point2;
		private Vector4 _point3;
		private Vector4 _point4;

		[Ordinal(0)] 
		[RED("point1")] 
		public Vector4 Point1
		{
			get => GetProperty(ref _point1);
			set => SetProperty(ref _point1, value);
		}

		[Ordinal(1)] 
		[RED("point2")] 
		public Vector4 Point2
		{
			get => GetProperty(ref _point2);
			set => SetProperty(ref _point2, value);
		}

		[Ordinal(2)] 
		[RED("point3")] 
		public Vector4 Point3
		{
			get => GetProperty(ref _point3);
			set => SetProperty(ref _point3, value);
		}

		[Ordinal(3)] 
		[RED("point4")] 
		public Vector4 Point4
		{
			get => GetProperty(ref _point4);
			set => SetProperty(ref _point4, value);
		}
	}
}
