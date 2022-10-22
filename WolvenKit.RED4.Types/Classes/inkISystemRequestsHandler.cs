using static WolvenKit.RED4.Types.Enums;

namespace WolvenKit.RED4.Types
{
	public partial class inkISystemRequestsHandler : IScriptable
	{
		[Ordinal(0)] 
		[RED("SavesForSaveReady")] 
		public inkSystemRequesResult SavesForSaveReady
		{
			get => GetPropertyValue<inkSystemRequesResult>();
			set => SetPropertyValue<inkSystemRequesResult>(value);
		}

		[Ordinal(1)] 
		[RED("SavesForLoadReady")] 
		public inkSystemRequesResult SavesForLoadReady
		{
			get => GetPropertyValue<inkSystemRequesResult>();
			set => SetPropertyValue<inkSystemRequesResult>(value);
		}

		[Ordinal(2)] 
		[RED("SaveMetadataReady")] 
		public inkSaveMetadataRequestResult SaveMetadataReady
		{
			get => GetPropertyValue<inkSaveMetadataRequestResult>();
			set => SetPropertyValue<inkSaveMetadataRequestResult>(value);
		}

		[Ordinal(3)] 
		[RED("GogLoginStatusChanged")] 
		public inkOnGogLoginStatusChangedResult GogLoginStatusChanged
		{
			get => GetPropertyValue<inkOnGogLoginStatusChangedResult>();
			set => SetPropertyValue<inkOnGogLoginStatusChangedResult>(value);
		}

		[Ordinal(4)] 
		[RED("SaveDeleted")] 
		public inkDeleteRequestResult SaveDeleted
		{
			get => GetPropertyValue<inkDeleteRequestResult>();
			set => SetPropertyValue<inkDeleteRequestResult>(value);
		}

		[Ordinal(5)] 
		[RED("SaveTransferUpdate")] 
		public inkSaveTransferRequestUpdate SaveTransferUpdate
		{
			get => GetPropertyValue<inkSaveTransferRequestUpdate>();
			set => SetPropertyValue<inkSaveTransferRequestUpdate>(value);
		}

		[Ordinal(6)] 
		[RED("ServersSearchResult")] 
		public inkSystemServerRequesResult ServersSearchResult
		{
			get => GetPropertyValue<inkSystemServerRequesResult>();
			set => SetPropertyValue<inkSystemServerRequesResult>(value);
		}

		[Ordinal(7)] 
		[RED("UserChanged")] 
		public inkUserIdResult UserChanged
		{
			get => GetPropertyValue<inkUserIdResult>();
			set => SetPropertyValue<inkUserIdResult>(value);
		}

		[Ordinal(8)] 
		[RED("UserIdResult")] 
		public inkUserIdResult UserIdResult
		{
			get => GetPropertyValue<inkUserIdResult>();
			set => SetPropertyValue<inkUserIdResult>(value);
		}

		[Ordinal(9)] 
		[RED("TrialVersionRemainingTimeUpdated")] 
		public inkTrialVersionRemainingTimeUpdate TrialVersionRemainingTimeUpdated
		{
			get => GetPropertyValue<inkTrialVersionRemainingTimeUpdate>();
			set => SetPropertyValue<inkTrialVersionRemainingTimeUpdate>(value);
		}

		[Ordinal(10)] 
		[RED("BoughtFullGame")] 
		public inkTrialOnBuyFullGame BoughtFullGame
		{
			get => GetPropertyValue<inkTrialOnBuyFullGame>();
			set => SetPropertyValue<inkTrialOnBuyFullGame>(value);
		}

		[Ordinal(11)] 
		[RED("CloudSavesQueryStatusChanged")] 
		public inkCloudSavesQueryStatusChange CloudSavesQueryStatusChanged
		{
			get => GetPropertyValue<inkCloudSavesQueryStatusChange>();
			set => SetPropertyValue<inkCloudSavesQueryStatusChange>(value);
		}

		[Ordinal(12)] 
		[RED("CloudSaveUploadFinish")] 
		public inkCloudSaveUploadFinish CloudSaveUploadFinish
		{
			get => GetPropertyValue<inkCloudSaveUploadFinish>();
			set => SetPropertyValue<inkCloudSaveUploadFinish>(value);
		}

		public inkISystemRequestsHandler()
		{
			PostConstruct();
		}

		partial void PostConstruct();
	}
}
