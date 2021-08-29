using static WolvenKit.RED4.Types.Enums;

namespace WolvenKit.RED4.Types
{
	[REDMeta]
	public partial class inkISystemRequestsHandler : IScriptable
	{
		private inkSystemRequesResult _savesReady;
		private inkSaveMetadataRequestResult _saveMetadataReady;
		private inkDeleteRequestResult _saveDeleted;
		private inkSystemServerRequesResult _serversSearchResult;
		private inkUserIdResult _userChanged;
		private inkUserIdResult _userIdResult;

		[Ordinal(0)] 
		[RED("SavesReady")] 
		public inkSystemRequesResult SavesReady
		{
			get => GetProperty(ref _savesReady);
			set => SetProperty(ref _savesReady, value);
		}

		[Ordinal(1)] 
		[RED("SaveMetadataReady")] 
		public inkSaveMetadataRequestResult SaveMetadataReady
		{
			get => GetProperty(ref _saveMetadataReady);
			set => SetProperty(ref _saveMetadataReady, value);
		}

		[Ordinal(2)] 
		[RED("SaveDeleted")] 
		public inkDeleteRequestResult SaveDeleted
		{
			get => GetProperty(ref _saveDeleted);
			set => SetProperty(ref _saveDeleted, value);
		}

		[Ordinal(3)] 
		[RED("ServersSearchResult")] 
		public inkSystemServerRequesResult ServersSearchResult
		{
			get => GetProperty(ref _serversSearchResult);
			set => SetProperty(ref _serversSearchResult, value);
		}

		[Ordinal(4)] 
		[RED("UserChanged")] 
		public inkUserIdResult UserChanged
		{
			get => GetProperty(ref _userChanged);
			set => SetProperty(ref _userChanged, value);
		}

		[Ordinal(5)] 
		[RED("UserIdResult")] 
		public inkUserIdResult UserIdResult
		{
			get => GetProperty(ref _userIdResult);
			set => SetProperty(ref _userIdResult, value);
		}
	}
}
