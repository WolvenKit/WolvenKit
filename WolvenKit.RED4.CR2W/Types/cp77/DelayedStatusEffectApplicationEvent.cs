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
			get => GetProperty(ref _statusEffectEvent);
			set => SetProperty(ref _statusEffectEvent, value);
		}

		public DelayedStatusEffectApplicationEvent(IRed4EngineFile cr2w, CVariable parent, string name) : base(cr2w, parent, name) { }
	}
}
