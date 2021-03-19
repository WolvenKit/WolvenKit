using WolvenKit.RED4.CR2W.Reflection;
using FastMember;
using static WolvenKit.RED4.CR2W.Types.Enums;

namespace WolvenKit.RED4.CR2W.Types
{
	[REDMeta]
	public class RequestDeviceWidgetsUpdateEvent : RequestWidgetUpdateEvent
	{
		private CArray<gamePersistentID> _requesters;

		[Ordinal(2)] 
		[RED("requesters")] 
		public CArray<gamePersistentID> Requesters
		{
			get => GetProperty(ref _requesters);
			set => SetProperty(ref _requesters, value);
		}

		public RequestDeviceWidgetsUpdateEvent(CR2WFile cr2w, CVariable parent, string name) : base(cr2w, parent, name) { }
	}
}
