using static WolvenKit.RED4.Types.Enums;

namespace WolvenKit.RED4.Types
{
	[REDMeta]
	public partial class RequestBreadCrumbBarUpdateEvent : redEvent
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
	}
}
