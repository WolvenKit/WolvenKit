using static WolvenKit.RED4.Types.Enums;

namespace WolvenKit.RED4.Types
{
	[REDMeta]
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
		[RED("SaveDeleted")] 
		public inkDeleteRequestResult SaveDeleted
		{
			get => GetPropertyValue<inkDeleteRequestResult>();
			set => SetPropertyValue<inkDeleteRequestResult>(value);
		}

		[Ordinal(4)] 
		[RED("SaveTransferUpdate")] 
		public inkSaveTransferRequestUpdate SaveTransferUpdate
		{
			get => GetPropertyValue<inkSaveTransferRequestUpdate>();
			set => SetPropertyValue<inkSaveTransferRequestUpdate>(value);
		}

		[Ordinal(5)] 
		[RED("ServersSearchResult")] 
		public inkSystemServerRequesResult ServersSearchResult
		{
			get => GetPropertyValue<inkSystemServerRequesResult>();
			set => SetPropertyValue<inkSystemServerRequesResult>(value);
		}

		[Ordinal(6)] 
		[RED("UserChanged")] 
		public inkUserIdResult UserChanged
		{
			get => GetPropertyValue<inkUserIdResult>();
			set => SetPropertyValue<inkUserIdResult>(value);
		}

		[Ordinal(7)] 
		[RED("UserIdResult")] 
		public inkUserIdResult UserIdResult
		{
			get => GetPropertyValue<inkUserIdResult>();
			set => SetPropertyValue<inkUserIdResult>(value);
		}

		[Ordinal(8)] 
		[RED("TrialVersionRemainingTimeUpdated")] 
		public inkTrialVersionRemainingTimeUpdate TrialVersionRemainingTimeUpdated
		{
			get => GetPropertyValue<inkTrialVersionRemainingTimeUpdate>();
			set => SetPropertyValue<inkTrialVersionRemainingTimeUpdate>(value);
		}

		[Ordinal(9)] 
		[RED("BoughtFullGame")] 
		public inkTrialOnBuyFullGame BoughtFullGame
		{
			get => GetPropertyValue<inkTrialOnBuyFullGame>();
			set => SetPropertyValue<inkTrialOnBuyFullGame>(value);
		}
	}
}
