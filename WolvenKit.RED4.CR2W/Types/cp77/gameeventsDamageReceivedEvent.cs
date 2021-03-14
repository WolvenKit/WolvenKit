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
			get
			{
				if (_hitEvent == null)
				{
					_hitEvent = (CHandle<gameeventsHitEvent>) CR2WTypeManager.Create("handle:gameeventsHitEvent", "hitEvent", cr2w, this);
				}
				return _hitEvent;
			}
			set
			{
				if (_hitEvent == value)
				{
					return;
				}
				_hitEvent = value;
				PropertySet(this);
			}
		}

		[Ordinal(1)] 
		[RED("totalDamageReceived")] 
		public CFloat TotalDamageReceived
		{
			get
			{
				if (_totalDamageReceived == null)
				{
					_totalDamageReceived = (CFloat) CR2WTypeManager.Create("Float", "totalDamageReceived", cr2w, this);
				}
				return _totalDamageReceived;
			}
			set
			{
				if (_totalDamageReceived == value)
				{
					return;
				}
				_totalDamageReceived = value;
				PropertySet(this);
			}
		}

		public gameeventsDamageReceivedEvent(CR2WFile cr2w, CVariable parent, string name) : base(cr2w, parent, name) { }
	}
}
