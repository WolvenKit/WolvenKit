using static WolvenKit.RED4.Types.Enums;

namespace WolvenKit.RED4.Types
{
	public partial class UpdateModsPopupData2 : inkUpdateModsPopupData
	{
		[Ordinal(7)] 
		[RED("modInfoList")] 
		public CArray<inkModToUpdateInfo> ModInfoList
		{
			get => GetPropertyValue<CArray<inkModToUpdateInfo>>();
			set => SetPropertyValue<CArray<inkModToUpdateInfo>>(value);
		}

		[Ordinal(8)] 
		[RED("bHaveModsBeenDeleted")] 
		public CBool BHaveModsBeenDeleted
		{
			get => GetPropertyValue<CBool>();
			set => SetPropertyValue<CBool>(value);
		}

		[Ordinal(9)] 
		[RED("bShouldShowThumbnail")] 
		public CBool BShouldShowThumbnail
		{
			get => GetPropertyValue<CBool>();
			set => SetPropertyValue<CBool>(value);
		}

		[Ordinal(10)] 
		[RED("bShouldShowModNames")] 
		public CBool BShouldShowModNames
		{
			get => GetPropertyValue<CBool>();
			set => SetPropertyValue<CBool>(value);
		}

		[Ordinal(11)] 
		[RED("bShouldShowConfirmButton")] 
		public CBool BShouldShowConfirmButton
		{
			get => GetPropertyValue<CBool>();
			set => SetPropertyValue<CBool>(value);
		}

		[Ordinal(12)] 
		[RED("bDefaultModsSelected")] 
		public CBool BDefaultModsSelected
		{
			get => GetPropertyValue<CBool>();
			set => SetPropertyValue<CBool>(value);
		}

		[Ordinal(13)] 
		[RED("deprecatedModsCount")] 
		public CInt32 DeprecatedModsCount
		{
			get => GetPropertyValue<CInt32>();
			set => SetPropertyValue<CInt32>(value);
		}

		[Ordinal(14)] 
		[RED("bDoesNumberExceedModLimit")] 
		public CBool BDoesNumberExceedModLimit
		{
			get => GetPropertyValue<CBool>();
			set => SetPropertyValue<CBool>(value);
		}

		[Ordinal(15)] 
		[RED("bIsForLoadingASave")] 
		public CBool BIsForLoadingASave
		{
			get => GetPropertyValue<CBool>();
			set => SetPropertyValue<CBool>(value);
		}

		public UpdateModsPopupData2()
		{
			ModInfoList = new();

			PostConstruct();
		}

		partial void PostConstruct();
	}
}
