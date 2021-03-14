using WolvenKit.RED4.CR2W.Reflection;
using FastMember;
using static WolvenKit.RED4.CR2W.Types.Enums;

namespace WolvenKit.RED4.CR2W.Types
{
	[REDMeta]
	public class CombatGadgetQuickThrowEvents : CombatGadgetTransitions
	{
		private CBool _grenadeThrown;
		private CBool _event;

		[Ordinal(0)] 
		[RED("grenadeThrown")] 
		public CBool GrenadeThrown
		{
			get
			{
				if (_grenadeThrown == null)
				{
					_grenadeThrown = (CBool) CR2WTypeManager.Create("Bool", "grenadeThrown", cr2w, this);
				}
				return _grenadeThrown;
			}
			set
			{
				if (_grenadeThrown == value)
				{
					return;
				}
				_grenadeThrown = value;
				PropertySet(this);
			}
		}

		[Ordinal(1)] 
		[RED("event")] 
		public CBool Event
		{
			get
			{
				if (_event == null)
				{
					_event = (CBool) CR2WTypeManager.Create("Bool", "event", cr2w, this);
				}
				return _event;
			}
			set
			{
				if (_event == value)
				{
					return;
				}
				_event = value;
				PropertySet(this);
			}
		}

		public CombatGadgetQuickThrowEvents(CR2WFile cr2w, CVariable parent, string name) : base(cr2w, parent, name) { }
	}
}
