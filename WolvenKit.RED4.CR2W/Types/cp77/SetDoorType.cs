using WolvenKit.RED4.CR2W.Reflection;
using FastMember;
using static WolvenKit.RED4.CR2W.Types.Enums;

namespace WolvenKit.RED4.CR2W.Types
{
	[REDMeta]
	public class SetDoorType : redEvent
	{
		private CEnum<EDoorType> _doorTypeSideOne;
		private CEnum<EDoorType> _doorTypeSideTwo;

		[Ordinal(0)] 
		[RED("doorTypeSideOne")] 
		public CEnum<EDoorType> DoorTypeSideOne
		{
			get
			{
				if (_doorTypeSideOne == null)
				{
					_doorTypeSideOne = (CEnum<EDoorType>) CR2WTypeManager.Create("EDoorType", "doorTypeSideOne", cr2w, this);
				}
				return _doorTypeSideOne;
			}
			set
			{
				if (_doorTypeSideOne == value)
				{
					return;
				}
				_doorTypeSideOne = value;
				PropertySet(this);
			}
		}

		[Ordinal(1)] 
		[RED("doorTypeSideTwo")] 
		public CEnum<EDoorType> DoorTypeSideTwo
		{
			get
			{
				if (_doorTypeSideTwo == null)
				{
					_doorTypeSideTwo = (CEnum<EDoorType>) CR2WTypeManager.Create("EDoorType", "doorTypeSideTwo", cr2w, this);
				}
				return _doorTypeSideTwo;
			}
			set
			{
				if (_doorTypeSideTwo == value)
				{
					return;
				}
				_doorTypeSideTwo = value;
				PropertySet(this);
			}
		}

		public SetDoorType(CR2WFile cr2w, CVariable parent, string name) : base(cr2w, parent, name) { }
	}
}
