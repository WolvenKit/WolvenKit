using WolvenKit.RED4.CR2W.Reflection;
using FastMember;
using static WolvenKit.RED4.CR2W.Types.Enums;

namespace WolvenKit.RED4.CR2W.Types
{
	[REDMeta]
	public class Transform : CVariable
	{
		private Vector4 _position;
		private Quaternion _orientation;

		[Ordinal(0)] 
		[RED("position")] 
		public Vector4 Position
		{
			get
			{
				if (_position == null)
				{
					_position = (Vector4) CR2WTypeManager.Create("Vector4", "position", cr2w, this);
				}
				return _position;
			}
			set
			{
				if (_position == value)
				{
					return;
				}
				_position = value;
				PropertySet(this);
			}
		}

		[Ordinal(1)] 
		[RED("orientation")] 
		public Quaternion Orientation
		{
			get
			{
				if (_orientation == null)
				{
					_orientation = (Quaternion) CR2WTypeManager.Create("Quaternion", "orientation", cr2w, this);
				}
				return _orientation;
			}
			set
			{
				if (_orientation == value)
				{
					return;
				}
				_orientation = value;
				PropertySet(this);
			}
		}

		public Transform(CR2WFile cr2w, CVariable parent, string name) : base(cr2w, parent, name) { }
	}
}
