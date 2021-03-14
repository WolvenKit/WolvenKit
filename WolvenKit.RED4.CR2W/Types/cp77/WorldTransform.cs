using WolvenKit.RED4.CR2W.Reflection;
using FastMember;
using static WolvenKit.RED4.CR2W.Types.Enums;

namespace WolvenKit.RED4.CR2W.Types
{
	[REDMeta]
	public class WorldTransform : CVariable
	{
		private WorldPosition _position;
		private Quaternion _orientation;

		[Ordinal(0)] 
		[RED("Position")] 
		public WorldPosition Position
		{
			get
			{
				if (_position == null)
				{
					_position = (WorldPosition) CR2WTypeManager.Create("WorldPosition", "Position", cr2w, this);
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
		[RED("Orientation")] 
		public Quaternion Orientation
		{
			get
			{
				if (_orientation == null)
				{
					_orientation = (Quaternion) CR2WTypeManager.Create("Quaternion", "Orientation", cr2w, this);
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

		public WorldTransform(CR2WFile cr2w, CVariable parent, string name) : base(cr2w, parent, name) { }
	}
}
