using WolvenKit.RED4.CR2W.Reflection;
using FastMember;
using static WolvenKit.RED4.CR2W.Types.Enums;

namespace WolvenKit.RED4.CR2W.Types
{
	[REDMeta]
	public class gameprojectileForwardEventToProjectileEvent : redEvent
	{
		private CHandle<redEvent> _eventToForward;

		[Ordinal(0)] 
		[RED("eventToForward")] 
		public CHandle<redEvent> EventToForward
		{
			get
			{
				if (_eventToForward == null)
				{
					_eventToForward = (CHandle<redEvent>) CR2WTypeManager.Create("handle:redEvent", "eventToForward", cr2w, this);
				}
				return _eventToForward;
			}
			set
			{
				if (_eventToForward == value)
				{
					return;
				}
				_eventToForward = value;
				PropertySet(this);
			}
		}

		public gameprojectileForwardEventToProjectileEvent(CR2WFile cr2w, CVariable parent, string name) : base(cr2w, parent, name) { }
	}
}
