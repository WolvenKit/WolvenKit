using static WolvenKit.RED4.Types.Enums;

namespace WolvenKit.RED4.Types
{
	[REDMeta]
	public partial class inkISystemRequestsHandler : IScriptable
	{
		[Ordinal(0)] 
		[RED("SavesReady")] 
		public inkSystemRequesResult SavesReady
		{
			get => GetPropertyValue<inkSystemRequesResult>();
			set => SetPropertyValue<inkSystemRequesResult>(value);
		}

		[Ordinal(1)] 
		[RED("SaveMetadataReady")] 
		public inkSaveMetadataRequestResult SaveMetadataReady
		{
			get => GetPropertyValue<inkSaveMetadataRequestResult>();
			set => SetPropertyValue<inkSaveMetadataRequestResult>(value);
		}

		[Ordinal(2)] 
		[RED("SaveDeleted")] 
		public inkDeleteRequestResult SaveDeleted
		{
			get => GetPropertyValue<inkDeleteRequestResult>();
			set => SetPropertyValue<inkDeleteRequestResult>(value);
		}

		[Ordinal(3)] 
		[RED("ServersSearchResult")] 
		public inkSystemServerRequesResult ServersSearchResult
		{
			get => GetPropertyValue<inkSystemServerRequesResult>();
			set => SetPropertyValue<inkSystemServerRequesResult>(value);
		}

		[Ordinal(4)] 
		[RED("UserChanged")] 
		public inkUserIdResult UserChanged
		{
			get => GetPropertyValue<inkUserIdResult>();
			set => SetPropertyValue<inkUserIdResult>(value);
		}

		[Ordinal(5)] 
		[RED("UserIdResult")] 
		public inkUserIdResult UserIdResult
		{
			get => GetPropertyValue<inkUserIdResult>();
			set => SetPropertyValue<inkUserIdResult>(value);
		}
	}
}
