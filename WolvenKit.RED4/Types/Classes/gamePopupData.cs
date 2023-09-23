using static WolvenKit.RED4.Types.Enums;

namespace WolvenKit.RED4.Types
{
	public partial class gamePopupData : RedBaseClass
	{
		[Ordinal(0)] 
		[RED("title")] 
		public CString Title
		{
			get => GetPropertyValue<CString>();
			set => SetPropertyValue<CString>(value);
		}

		[Ordinal(1)] 
		[RED("message")] 
		public CString Message
		{
			get => GetPropertyValue<CString>();
			set => SetPropertyValue<CString>(value);
		}

		[Ordinal(2)] 
		[RED("messageOverrideDataList")] 
		public CArray<CHandle<gameJournalEntryOverrideData>> MessageOverrideDataList
		{
			get => GetPropertyValue<CArray<CHandle<gameJournalEntryOverrideData>>>();
			set => SetPropertyValue<CArray<CHandle<gameJournalEntryOverrideData>>>(value);
		}

		[Ordinal(3)] 
		[RED("iconID")] 
		public TweakDBID IconID
		{
			get => GetPropertyValue<TweakDBID>();
			set => SetPropertyValue<TweakDBID>(value);
		}

		[Ordinal(4)] 
		[RED("isModal")] 
		public CBool IsModal
		{
			get => GetPropertyValue<CBool>();
			set => SetPropertyValue<CBool>(value);
		}

		[Ordinal(5)] 
		[RED("videoType")] 
		public CEnum<gameVideoType> VideoType
		{
			get => GetPropertyValue<CEnum<gameVideoType>>();
			set => SetPropertyValue<CEnum<gameVideoType>>(value);
		}

		[Ordinal(6)] 
		[RED("video")] 
		public CResourceAsyncReference<Bink> Video
		{
			get => GetPropertyValue<CResourceAsyncReference<Bink>>();
			set => SetPropertyValue<CResourceAsyncReference<Bink>>(value);
		}

		public gamePopupData()
		{
			MessageOverrideDataList = new();
			VideoType = Enums.gameVideoType.Unknown;

			PostConstruct();
		}

		partial void PostConstruct();
	}
}
