using static WolvenKit.RED4.Types.Enums;

namespace WolvenKit.RED4.Types
{
	[REDMeta]
	public partial class ComputerMenuWidgetController : inkWidgetLogicController
	{
		private inkWidgetReference _thumbnailsListWidget;
		private inkWidgetReference _contentWidget;
		private CBool _isInitialized;
		private CArray<SDocumentWidgetPackage> _fileWidgetsData;
		private CArray<SDocumentThumbnailWidgetPackage> _fileThumbnailWidgetsData;

		[Ordinal(1)] 
		[RED("thumbnailsListWidget")] 
		public inkWidgetReference ThumbnailsListWidget
		{
			get => GetProperty(ref _thumbnailsListWidget);
			set => SetProperty(ref _thumbnailsListWidget, value);
		}

		[Ordinal(2)] 
		[RED("contentWidget")] 
		public inkWidgetReference ContentWidget
		{
			get => GetProperty(ref _contentWidget);
			set => SetProperty(ref _contentWidget, value);
		}

		[Ordinal(3)] 
		[RED("isInitialized")] 
		public CBool IsInitialized
		{
			get => GetProperty(ref _isInitialized);
			set => SetProperty(ref _isInitialized, value);
		}

		[Ordinal(4)] 
		[RED("fileWidgetsData")] 
		public CArray<SDocumentWidgetPackage> FileWidgetsData
		{
			get => GetProperty(ref _fileWidgetsData);
			set => SetProperty(ref _fileWidgetsData, value);
		}

		[Ordinal(5)] 
		[RED("fileThumbnailWidgetsData")] 
		public CArray<SDocumentThumbnailWidgetPackage> FileThumbnailWidgetsData
		{
			get => GetProperty(ref _fileThumbnailWidgetsData);
			set => SetProperty(ref _fileThumbnailWidgetsData, value);
		}
	}
}
