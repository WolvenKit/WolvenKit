using static WolvenKit.RED4.Types.Enums;

namespace WolvenKit.RED4.Types
{
	public partial class worldTrafficLanePolygonRepresentation : RedBaseClass
	{
		[Ordinal(0)] 
		[RED("outline")] 
		public CArray<Vector3> Outline
		{
			get => GetPropertyValue<CArray<Vector3>>();
			set => SetPropertyValue<CArray<Vector3>>(value);
		}

		[Ordinal(1)] 
		[RED("polygon")] 
		public CArray<Vector2> Polygon
		{
			get => GetPropertyValue<CArray<Vector2>>();
			set => SetPropertyValue<CArray<Vector2>>(value);
		}

		public worldTrafficLanePolygonRepresentation()
		{
			Outline = new();
			Polygon = new();

			PostConstruct();
		}

		partial void PostConstruct();
	}
}
