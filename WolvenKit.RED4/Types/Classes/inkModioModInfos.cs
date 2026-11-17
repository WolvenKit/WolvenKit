using static WolvenKit.RED4.Types.Enums;

namespace WolvenKit.RED4.Types
{
	public partial class inkModioModInfos : RedBaseClass
	{
		[Ordinal(0)] 
		[RED("name")] 
		public CString Name
		{
			get => GetPropertyValue<CString>();
			set => SetPropertyValue<CString>(value);
		}

		[Ordinal(1)] 
		[RED("authorName")] 
		public CString AuthorName
		{
			get => GetPropertyValue<CString>();
			set => SetPropertyValue<CString>(value);
		}

		[Ordinal(2)] 
		[RED("authorLinkedAccountName")] 
		public CString AuthorLinkedAccountName
		{
			get => GetPropertyValue<CString>();
			set => SetPropertyValue<CString>(value);
		}

		[Ordinal(3)] 
		[RED("authorID")] 
		public CInt64 AuthorID
		{
			get => GetPropertyValue<CInt64>();
			set => SetPropertyValue<CInt64>(value);
		}

		[Ordinal(4)] 
		[RED("version")] 
		public CString Version
		{
			get => GetPropertyValue<CString>();
			set => SetPropertyValue<CString>(value);
		}

		[Ordinal(5)] 
		[RED("changelog")] 
		public CString Changelog
		{
			get => GetPropertyValue<CString>();
			set => SetPropertyValue<CString>(value);
		}

		[Ordinal(6)] 
		[RED("description")] 
		public CString Description
		{
			get => GetPropertyValue<CString>();
			set => SetPropertyValue<CString>(value);
		}

		[Ordinal(7)] 
		[RED("summary")] 
		public CString Summary
		{
			get => GetPropertyValue<CString>();
			set => SetPropertyValue<CString>(value);
		}

		[Ordinal(8)] 
		[RED("rating")] 
		public CInt64 Rating
		{
			get => GetPropertyValue<CInt64>();
			set => SetPropertyValue<CInt64>(value);
		}

		[Ordinal(9)] 
		[RED("size")] 
		public CUInt64 Size
		{
			get => GetPropertyValue<CUInt64>();
			set => SetPropertyValue<CUInt64>(value);
		}

		[Ordinal(10)] 
		[RED("downloadsTotal")] 
		public CInt64 DownloadsTotal
		{
			get => GetPropertyValue<CInt64>();
			set => SetPropertyValue<CInt64>(value);
		}

		[Ordinal(11)] 
		[RED("dateAdded")] 
		public CInt64 DateAdded
		{
			get => GetPropertyValue<CInt64>();
			set => SetPropertyValue<CInt64>(value);
		}

		[Ordinal(12)] 
		[RED("dateUpdated")] 
		public CInt64 DateUpdated
		{
			get => GetPropertyValue<CInt64>();
			set => SetPropertyValue<CInt64>(value);
		}

		[Ordinal(13)] 
		[RED("id")] 
		public CInt64 Id
		{
			get => GetPropertyValue<CInt64>();
			set => SetPropertyValue<CInt64>(value);
		}

		[Ordinal(14)] 
		[RED("bIsUserSubscribedToMod")] 
		public CBool BIsUserSubscribedToMod
		{
			get => GetPropertyValue<CBool>();
			set => SetPropertyValue<CBool>(value);
		}

		[Ordinal(15)] 
		[RED("bIsModInstalled")] 
		public CBool BIsModInstalled
		{
			get => GetPropertyValue<CBool>();
			set => SetPropertyValue<CBool>(value);
		}

		[Ordinal(16)] 
		[RED("bIsUserLikingMod")] 
		public CBool BIsUserLikingMod
		{
			get => GetPropertyValue<CBool>();
			set => SetPropertyValue<CBool>(value);
		}

		[Ordinal(17)] 
		[RED("bIsModEnabledForUser")] 
		public CBool BIsModEnabledForUser
		{
			get => GetPropertyValue<CBool>();
			set => SetPropertyValue<CBool>(value);
		}

		[Ordinal(18)] 
		[RED("bIsModNewForUser")] 
		public CBool BIsModNewForUser
		{
			get => GetPropertyValue<CBool>();
			set => SetPropertyValue<CBool>(value);
		}

		[Ordinal(19)] 
		[RED("bIsModWaitingEndOfInstallation")] 
		public CBool BIsModWaitingEndOfInstallation
		{
			get => GetPropertyValue<CBool>();
			set => SetPropertyValue<CBool>(value);
		}

		[Ordinal(20)] 
		[RED("modState")] 
		public CEnum<inkModioModState> ModState
		{
			get => GetPropertyValue<CEnum<inkModioModState>>();
			set => SetPropertyValue<CEnum<inkModioModState>>(value);
		}

		[Ordinal(21)] 
		[RED("gallerySize")] 
		public CInt64 GallerySize
		{
			get => GetPropertyValue<CInt64>();
			set => SetPropertyValue<CInt64>(value);
		}

		[Ordinal(22)] 
		[RED("tags")] 
		public CArray<CString> Tags
		{
			get => GetPropertyValue<CArray<CString>>();
			set => SetPropertyValue<CArray<CString>>(value);
		}

		[Ordinal(23)] 
		[RED("localizedTags")] 
		public CArray<CString> LocalizedTags
		{
			get => GetPropertyValue<CArray<CString>>();
			set => SetPropertyValue<CArray<CString>>(value);
		}

		public inkModioModInfos()
		{
			ModState = Enums.inkModioModState.MAX;
			Tags = new();
			LocalizedTags = new();

			PostConstruct();
		}

		partial void PostConstruct();
	}
}
