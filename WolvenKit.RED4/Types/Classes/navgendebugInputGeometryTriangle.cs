using static WolvenKit.RED4.Types.Enums;

namespace WolvenKit.RED4.Types
{
	public partial class navgendebugInputGeometryTriangle : RedBaseClass
	{
		[Ordinal(0)] 
		[RED("vertices", 3)] 
		public CArrayFixedSize<Vector3> Vertices
		{
			get => GetPropertyValue<CArrayFixedSize<Vector3>>();
			set => SetPropertyValue<CArrayFixedSize<Vector3>>(value);
		}

		[Ordinal(1)] 
		[RED("area")] 
		public CUInt8 Area
		{
			get => GetPropertyValue<CUInt8>();
			set => SetPropertyValue<CUInt8>(value);
		}

		public navgendebugInputGeometryTriangle()
		{
			Vertices = new(3);

			PostConstruct();
		}

		partial void PostConstruct();
	}
}
