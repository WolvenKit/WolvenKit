using WolvenKit.RED4.CR2W.Reflection;
using FastMember;
using static WolvenKit.RED4.CR2W.Types.Enums;

namespace WolvenKit.RED4.CR2W.Types
{
	[REDMeta]
	public class AreaShapeOutline : ISerializable
	{
		private CArray<Vector3> _points;
		private CFloat _height;

		[Ordinal(0)] 
		[RED("points")] 
		public CArray<Vector3> Points
		{
			get
			{
				if (_points == null)
				{
					_points = (CArray<Vector3>) CR2WTypeManager.Create("array:Vector3", "points", cr2w, this);
				}
				return _points;
			}
			set
			{
				if (_points == value)
				{
					return;
				}
				_points = value;
				PropertySet(this);
			}
		}

		[Ordinal(1)] 
		[RED("height")] 
		public CFloat Height
		{
			get
			{
				if (_height == null)
				{
					_height = (CFloat) CR2WTypeManager.Create("Float", "height", cr2w, this);
				}
				return _height;
			}
			set
			{
				if (_height == value)
				{
					return;
				}
				_height = value;
				PropertySet(this);
			}
		}

		public AreaShapeOutline(CR2WFile cr2w, CVariable parent, string name) : base(cr2w, parent, name) { }
	}
}
