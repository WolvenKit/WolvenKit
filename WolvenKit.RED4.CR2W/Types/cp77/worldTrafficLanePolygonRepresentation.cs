using WolvenKit.RED4.CR2W.Reflection;
using FastMember;
using static WolvenKit.RED4.CR2W.Types.Enums;

namespace WolvenKit.RED4.CR2W.Types
{
	[REDMeta]
	public class worldTrafficLanePolygonRepresentation : CVariable
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

		public worldTrafficLanePolygonRepresentation(CR2WFile cr2w, CVariable parent, string name) : base(cr2w, parent, name) { }
	}
}
