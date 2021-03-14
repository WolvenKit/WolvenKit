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
			get
			{
				if (_outline == null)
				{
					_outline = (CArray<Vector3>) CR2WTypeManager.Create("array:Vector3", "outline", cr2w, this);
				}
				return _outline;
			}
			set
			{
				if (_outline == value)
				{
					return;
				}
				_outline = value;
				PropertySet(this);
			}
		}

		[Ordinal(1)] 
		[RED("polygon")] 
		public CArray<Vector2> Polygon
		{
			get
			{
				if (_polygon == null)
				{
					_polygon = (CArray<Vector2>) CR2WTypeManager.Create("array:Vector2", "polygon", cr2w, this);
				}
				return _polygon;
			}
			set
			{
				if (_polygon == value)
				{
					return;
				}
				_polygon = value;
				PropertySet(this);
			}
		}

		public worldTrafficLanePolygonRepresentation(CR2WFile cr2w, CVariable parent, string name) : base(cr2w, parent, name) { }
	}
}
