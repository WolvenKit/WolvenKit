using WolvenKit.RED4.CR2W.Reflection;
using FastMember;
using static WolvenKit.RED4.CR2W.Types.Enums;

namespace WolvenKit.RED4.CR2W.Types
{
	[REDMeta]
	public class ClimbEvents : LocomotionGroundEvents
	{
		private CArray<CHandle<entIKTargetAddEvent>> _ikHandEvents;
		private CBool _shouldIkHands;

		[Ordinal(0)] 
		[RED("ikHandEvents")] 
		public CArray<CHandle<entIKTargetAddEvent>> IkHandEvents
		{
			get
			{
				if (_ikHandEvents == null)
				{
					_ikHandEvents = (CArray<CHandle<entIKTargetAddEvent>>) CR2WTypeManager.Create("array:handle:entIKTargetAddEvent", "ikHandEvents", cr2w, this);
				}
				return _ikHandEvents;
			}
			set
			{
				if (_ikHandEvents == value)
				{
					return;
				}
				_ikHandEvents = value;
				PropertySet(this);
			}
		}

		[Ordinal(1)] 
		[RED("shouldIkHands")] 
		public CBool ShouldIkHands
		{
			get
			{
				if (_shouldIkHands == null)
				{
					_shouldIkHands = (CBool) CR2WTypeManager.Create("Bool", "shouldIkHands", cr2w, this);
				}
				return _shouldIkHands;
			}
			set
			{
				if (_shouldIkHands == value)
				{
					return;
				}
				_shouldIkHands = value;
				PropertySet(this);
			}
		}

		public ClimbEvents(CR2WFile cr2w, CVariable parent, string name) : base(cr2w, parent, name) { }
	}
}
