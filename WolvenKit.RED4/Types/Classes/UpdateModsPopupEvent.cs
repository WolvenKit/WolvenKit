using static WolvenKit.RED4.Types.Enums;

namespace WolvenKit.RED4.Types
{
	public partial class UpdateModsPopupEvent : redEvent
	{
		[Ordinal(0)] 
		[RED("modInfoList")] 
		public CArray<inkModToUpdateInfo> ModInfoList
		{
			get => GetPropertyValue<CArray<inkModToUpdateInfo>>();
			set => SetPropertyValue<CArray<inkModToUpdateInfo>>(value);
		}

		[Ordinal(1)] 
		[RED("bHaveModsBeenDeleted")] 
		public CBool BHaveModsBeenDeleted
		{
			get => GetPropertyValue<CBool>();
			set => SetPropertyValue<CBool>(value);
		}

		[Ordinal(2)] 
		[RED("bShouldShowThumbnail")] 
		public CBool BShouldShowThumbnail
		{
			get => GetPropertyValue<CBool>();
			set => SetPropertyValue<CBool>(value);
		}

		[Ordinal(3)] 
		[RED("bShouldShowModNames")] 
		public CBool BShouldShowModNames
		{
			get => GetPropertyValue<CBool>();
			set => SetPropertyValue<CBool>(value);
		}

		[Ordinal(4)] 
		[RED("bShouldShowConfirmButton")] 
		public CBool BShouldShowConfirmButton
		{
			get => GetPropertyValue<CBool>();
			set => SetPropertyValue<CBool>(value);
		}

		[Ordinal(5)] 
		[RED("bDefaultModsSelected")] 
		public CBool BDefaultModsSelected
		{
			get => GetPropertyValue<CBool>();
			set => SetPropertyValue<CBool>(value);
		}

		[Ordinal(6)] 
		[RED("deprecatedModsCount")] 
		public CInt32 DeprecatedModsCount
		{
			get => GetPropertyValue<CInt32>();
			set => SetPropertyValue<CInt32>(value);
		}

		[Ordinal(7)] 
		[RED("bDoesNumberExceedModLimit")] 
		public CBool BDoesNumberExceedModLimit
		{
			get => GetPropertyValue<CBool>();
			set => SetPropertyValue<CBool>(value);
		}

		[Ordinal(8)] 
		[RED("bIsForLoadingASave")] 
		public CBool BIsForLoadingASave
		{
			get => GetPropertyValue<CBool>();
			set => SetPropertyValue<CBool>(value);
		}

		public UpdateModsPopupEvent()
		{
			ModInfoList = new();
			BIsForLoadingASave = true;

			PostConstruct();
		}

		partial void PostConstruct();
	}
}
