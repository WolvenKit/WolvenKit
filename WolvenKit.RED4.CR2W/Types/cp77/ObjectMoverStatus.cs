using WolvenKit.RED4.CR2W.Reflection;
using FastMember;
using static WolvenKit.RED4.CR2W.Types.Enums;

namespace WolvenKit.RED4.CR2W.Types
{
	[REDMeta]
	public class ObjectMoverStatus : redEvent
	{
		private CName _ownerName;
		private CEnum<EMovementDirection> _direction;

		[Ordinal(0)] 
		[RED("ownerName")] 
		public CName OwnerName
		{
			get
			{
				if (_ownerName == null)
				{
					_ownerName = (CName) CR2WTypeManager.Create("CName", "ownerName", cr2w, this);
				}
				return _ownerName;
			}
			set
			{
				if (_ownerName == value)
				{
					return;
				}
				_ownerName = value;
				PropertySet(this);
			}
		}

		[Ordinal(1)] 
		[RED("direction")] 
		public CEnum<EMovementDirection> Direction
		{
			get
			{
				if (_direction == null)
				{
					_direction = (CEnum<EMovementDirection>) CR2WTypeManager.Create("EMovementDirection", "direction", cr2w, this);
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

		public ObjectMoverStatus(CR2WFile cr2w, CVariable parent, string name) : base(cr2w, parent, name) { }
	}
}
