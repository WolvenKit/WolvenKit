using WolvenKit.RED4.CR2W.Reflection;
using FastMember;
using static WolvenKit.RED4.CR2W.Types.Enums;

namespace WolvenKit.RED4.CR2W.Types
{
	[REDMeta]
	public class Segment : CVariable
	{
		private Vector4 _origin;
		private Vector4 _direction;

		[Ordinal(0)] 
		[RED("origin")] 
		public Vector4 Origin
		{
			get
			{
				if (_origin == null)
				{
					_origin = (Vector4) CR2WTypeManager.Create("Vector4", "origin", cr2w, this);
				}
				return _origin;
			}
			set
			{
				if (_origin == value)
				{
					return;
				}
				_origin = value;
				PropertySet(this);
			}
		}

		[Ordinal(1)] 
		[RED("direction")] 
		public Vector4 Direction
		{
			get
			{
				if (_direction == null)
				{
					_direction = (Vector4) CR2WTypeManager.Create("Vector4", "direction", cr2w, this);
				}
				return _direction;
			}
			set
			{
				if (_direction == value)
				{
					return;
				}
				_direction = value;
				PropertySet(this);
			}
		}

		public Segment(CR2WFile cr2w, CVariable parent, string name) : base(cr2w, parent, name) { }
	}
}
