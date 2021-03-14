using WolvenKit.RED4.CR2W.Reflection;
using FastMember;
using static WolvenKit.RED4.CR2W.Types.Enums;

namespace WolvenKit.RED4.CR2W.Types
{
	[REDMeta]
	public class GenericHitPrereqState : gamePrereqState
	{
		private CHandle<HitCallback> _listener;
		private CHandle<gameeventsHitEvent> _hitEvent;

		[Ordinal(0)] 
		[RED("listener")] 
		public CHandle<HitCallback> Listener
		{
			get
			{
				if (_listener == null)
				{
					_listener = (CHandle<HitCallback>) CR2WTypeManager.Create("handle:HitCallback", "listener", cr2w, this);
				}
				return _listener;
			}
			set
			{
				if (_listener == value)
				{
					return;
				}
				_listener = value;
				PropertySet(this);
			}
		}

		[Ordinal(1)] 
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

		public GenericHitPrereqState(CR2WFile cr2w, CVariable parent, string name) : base(cr2w, parent, name) { }
	}
}
