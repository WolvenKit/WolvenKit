using WolvenKit.RED4.CR2W.Reflection;
using FastMember;
using static WolvenKit.RED4.CR2W.Types.Enums;

namespace WolvenKit.RED4.CR2W.Types
{
	[REDMeta]
	public class workConnectedWorkspotNotificationEvent : redEvent
	{
		private CName _evtName;

		[Ordinal(0)] 
		[RED("evtName")] 
		public CName EvtName
		{
			get
			{
				if (_evtName == null)
				{
					_evtName = (CName) CR2WTypeManager.Create("CName", "evtName", cr2w, this);
				}
				return _evtName;
			}
			set
			{
				if (_evtName == value)
				{
					return;
				}
				_evtName = value;
				PropertySet(this);
			}
		}

		public workConnectedWorkspotNotificationEvent(CR2WFile cr2w, CVariable parent, string name) : base(cr2w, parent, name) { }
	}
}
