using WolvenKit.RED4.CR2W.Reflection;
using FastMember;
using static WolvenKit.RED4.CR2W.Types.Enums;

namespace WolvenKit.RED4.CR2W.Types
{
	[REDMeta]
	public class gameeventsDamageReceivedEvent : redEvent
	{
		private CHandle<gameeventsHitEvent> _hitEvent;
		private CFloat _totalDamageReceived;

		[Ordinal(0)] 
		[RED("hitEvent")] 
		public CHandle<gameeventsHitEvent> HitEvent
		{
			get => GetProperty(ref _hitEvent);
			set => SetProperty(ref _hitEvent, value);
		}

		[Ordinal(1)] 
		[RED("totalDamageReceived")] 
		public CFloat TotalDamageReceived
		{
			get => GetProperty(ref _totalDamageReceived);
			set => SetProperty(ref _totalDamageReceived, value);
		}

		public gameeventsDamageReceivedEvent(CR2WFile cr2w, CVariable parent, string name) : base(cr2w, parent, name) { }
	}
}
