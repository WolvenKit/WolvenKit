using WolvenKit.RED4.CR2W.Reflection;
using FastMember;
using static WolvenKit.RED4.CR2W.Types.Enums;

namespace WolvenKit.RED4.CR2W.Types
{
	[REDMeta]
	public class LiftSetMovementStateEvent : redEvent
	{
		private CEnum<gamePlatformMovementState> _movementState;

		[Ordinal(0)] 
		[RED("movementState")] 
		public CEnum<gamePlatformMovementState> MovementState
		{
			get
			{
				if (_movementState == null)
				{
					_movementState = (CEnum<gamePlatformMovementState>) CR2WTypeManager.Create("gamePlatformMovementState", "movementState", cr2w, this);
				}
				return _movementState;
			}
			set
			{
				if (_movementState == value)
				{
					return;
				}
				_movementState = value;
				PropertySet(this);
			}
		}

		public LiftSetMovementStateEvent(CR2WFile cr2w, CVariable parent, string name) : base(cr2w, parent, name) { }
	}
}
