using WolvenKit.RED4.CR2W.Reflection;
using FastMember;
using static WolvenKit.RED4.CR2W.Types.Enums;

namespace WolvenKit.RED4.CR2W.Types
{
	[REDMeta]
	public class DelayedStatusEffectApplicationEvent : redEvent
	{
		private CHandle<gameeventsApplyStatusEffectEvent> _statusEffectEvent;

		[Ordinal(0)] 
		[RED("statusEffectEvent")] 
		public CHandle<gameeventsApplyStatusEffectEvent> StatusEffectEvent
		{
			get
			{
				if (_statusEffectEvent == null)
				{
					_statusEffectEvent = (CHandle<gameeventsApplyStatusEffectEvent>) CR2WTypeManager.Create("handle:gameeventsApplyStatusEffectEvent", "statusEffectEvent", cr2w, this);
				}
				return _statusEffectEvent;
			}
			set
			{
				if (_statusEffectEvent == value)
				{
					return;
				}
				_statusEffectEvent = value;
				PropertySet(this);
			}
		}

		public DelayedStatusEffectApplicationEvent(CR2WFile cr2w, CVariable parent, string name) : base(cr2w, parent, name) { }
	}
}
