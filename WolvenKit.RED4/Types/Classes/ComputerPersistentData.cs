using static WolvenKit.RED4.Types.Enums;

namespace WolvenKit.RED4.Types
{
	public partial class ComputerPersistentData : RedBaseClass
	{
		[Ordinal(0)] 
		[RED("mails")] 
		public CArray<gamedeviceGenericDataContent> Mails
		{
			get => GetPropertyValue<CArray<gamedeviceGenericDataContent>>();
			set => SetPropertyValue<CArray<gamedeviceGenericDataContent>>(value);
		}

		[Ordinal(1)] 
		[RED("files")] 
		public CArray<gamedeviceGenericDataContent> Files
		{
			get => GetPropertyValue<CArray<gamedeviceGenericDataContent>>();
			set => SetPropertyValue<CArray<gamedeviceGenericDataContent>>(value);
		}

		[Ordinal(2)] 
		[RED("newsFeedElements")] 
		public CArray<SNewsFeedElementData> NewsFeedElements
		{
			get => GetPropertyValue<CArray<SNewsFeedElementData>>();
			set => SetPropertyValue<CArray<SNewsFeedElementData>>(value);
		}

		[Ordinal(3)] 
		[RED("internetData")] 
		public SInternetData InternetData
		{
			get => GetPropertyValue<SInternetData>();
			set => SetPropertyValue<SInternetData>(value);
		}

		[Ordinal(4)] 
		[RED("initialUIPosition")] 
		public CString InitialUIPosition
		{
			get => GetPropertyValue<CString>();
			set => SetPropertyValue<CString>(value);
		}

		[Ordinal(5)] 
		[RED("openedFileIDX")] 
		public CInt32 OpenedFileIDX
		{
			get => GetPropertyValue<CInt32>();
			set => SetPropertyValue<CInt32>(value);
		}

		[Ordinal(6)] 
		[RED("openedFolderIDX")] 
		public CInt32 OpenedFolderIDX
		{
			get => GetPropertyValue<CInt32>();
			set => SetPropertyValue<CInt32>(value);
		}

		public ComputerPersistentData()
		{
			Mails = new();
			Files = new();
			NewsFeedElements = new();
			InternetData = new SInternetData();

			PostConstruct();
		}

		partial void PostConstruct();
	}
}
