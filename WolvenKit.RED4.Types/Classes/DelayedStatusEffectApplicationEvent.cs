using static WolvenKit.RED4.Types.Enums;

namespace WolvenKit.RED4.Types
{
	[REDMeta]
	public partial class DelayedStatusEffectApplicationEvent : redEvent
	{
		private CHandle<gameeventsApplyStatusEffectEvent> _statusEffectEvent;

		[Ordinal(0)] 
		[RED("statusEffectEvent")] 
		public CHandle<gameeventsApplyStatusEffectEvent> StatusEffectEvent
		{
			get => GetProperty(ref _statusEffectEvent);
			set => SetProperty(ref _statusEffectEvent, value);
		}
	}
}
