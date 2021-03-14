using WolvenKit.RED4.CR2W.Reflection;
using FastMember;
using static WolvenKit.RED4.CR2W.Types.Enums;

namespace WolvenKit.RED4.CR2W.Types
{
	[REDMeta]
	public class vehicleUnmountPosition : CVariable
	{
		private CEnum<vehicleExitDirection> _direction;
		private WorldPosition _position;

		[Ordinal(0)] 
		[RED("direction")] 
		public CEnum<vehicleExitDirection> Direction
		{
			get
			{
				if (_direction == null)
				{
					_direction = (CEnum<vehicleExitDirection>) CR2WTypeManager.Create("vehicleExitDirection", "direction", cr2w, this);
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

		[Ordinal(1)] 
		[RED("position")] 
		public WorldPosition Position
		{
			get
			{
				if (_position == null)
				{
					_position = (WorldPosition) CR2WTypeManager.Create("WorldPosition", "position", cr2w, this);
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

		public vehicleUnmountPosition(CR2WFile cr2w, CVariable parent, string name) : base(cr2w, parent, name) { }
	}
}
