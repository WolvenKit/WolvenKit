using static WolvenKit.RED4.Types.Enums;

namespace WolvenKit.RED4.Types
{
	[REDMeta]
	public partial class worldTrafficLanePolygonRepresentation : RedBaseClass
	{
		private CArray<Vector3> _outline;
		private CArray<Vector2> _polygon;

		[Ordinal(0)] 
		[RED("outline")] 
		public CArray<Vector3> Outline
		{
			get => GetProperty(ref _outline);
			set => SetProperty(ref _outline, value);
		}

		[Ordinal(1)] 
		[RED("polygon")] 
		public CArray<Vector2> Polygon
		{
			get => GetProperty(ref _polygon);
			set => SetProperty(ref _polygon, value);
		}
	}
}
