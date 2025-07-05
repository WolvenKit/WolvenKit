using static WolvenKit.RED4.Types.Enums;

namespace WolvenKit.RED4.Types
{
	[REDClass(SerializeDefault = true)]
	public partial class Tetrahedron : RedBaseClass
	{
		[Ordinal(0)] 
		[RED("point1")] 
		public Vector4 Point1
		{
			get => GetPropertyValue<Vector4>();
			set => SetPropertyValue<Vector4>(value);
		}

		[Ordinal(1)] 
		[RED("point2")] 
		public Vector4 Point2
		{
			get => GetPropertyValue<Vector4>();
			set => SetPropertyValue<Vector4>(value);
		}

		[Ordinal(2)] 
		[RED("point3")] 
		public Vector4 Point3
		{
			get => GetPropertyValue<Vector4>();
			set => SetPropertyValue<Vector4>(value);
		}

		[Ordinal(3)] 
		[RED("point4")] 
		public Vector4 Point4
		{
			get => GetPropertyValue<Vector4>();
			set => SetPropertyValue<Vector4>(value);
		}

		public Tetrahedron()
		{
			Point1 = new Vector4();
			Point2 = new Vector4();
			Point3 = new Vector4();
			Point4 = new Vector4();

			PostConstruct();
		}

		partial void PostConstruct();
	}
}
