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
			get => GetProperty(ref _evtName);
			set => SetProperty(ref _evtName, value);
		}

		public workConnectedWorkspotNotificationEvent(IRed4EngineFile cr2w, CVariable parent, string name) : base(cr2w, parent, name) { }
	}
}
