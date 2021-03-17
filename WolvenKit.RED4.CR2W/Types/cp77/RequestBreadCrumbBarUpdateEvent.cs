using WolvenKit.RED4.CR2W.Reflection;
using FastMember;
using static WolvenKit.RED4.CR2W.Types.Enums;

namespace WolvenKit.RED4.CR2W.Types
{
	[REDMeta]
	public class RequestBreadCrumbBarUpdateEvent : redEvent
	{
		private gamePersistentID _requester;
		private SBreadCrumbUpdateData _breadCrumbData;

		[Ordinal(0)] 
		[RED("requester")] 
		public gamePersistentID Requester
		{
			get => GetProperty(ref _requester);
			set => SetProperty(ref _requester, value);
		}

		[Ordinal(1)] 
		[RED("breadCrumbData")] 
		public SBreadCrumbUpdateData BreadCrumbData
		{
			get => GetProperty(ref _breadCrumbData);
			set => SetProperty(ref _breadCrumbData, value);
		}

		public RequestBreadCrumbBarUpdateEvent(CR2WFile cr2w, CVariable parent, string name) : base(cr2w, parent, name) { }
	}
}
