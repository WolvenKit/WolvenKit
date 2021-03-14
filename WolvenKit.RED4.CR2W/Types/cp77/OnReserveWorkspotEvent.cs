using WolvenKit.RED4.CR2W.Reflection;
using FastMember;
using static WolvenKit.RED4.CR2W.Types.Enums;

namespace WolvenKit.RED4.CR2W.Types
{
	[REDMeta]
	public class OnReserveWorkspotEvent : OnWorkspotAvailabilityEvent
	{
		private CEnum<gamedataWorkspotActionType> _action;

		[Ordinal(1)] 
		[RED("action")] 
		public CEnum<gamedataWorkspotActionType> Action
		{
			get
			{
				if (_action == null)
				{
					_action = (CEnum<gamedataWorkspotActionType>) CR2WTypeManager.Create("gamedataWorkspotActionType", "action", cr2w, this);
				}
				return _action;
			}
			set
			{
				if (_action == value)
				{
					return;
				}
				_action = value;
				PropertySet(this);
			}
		}

		public OnReserveWorkspotEvent(CR2WFile cr2w, CVariable parent, string name) : base(cr2w, parent, name) { }
	}
}
