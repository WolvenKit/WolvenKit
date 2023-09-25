using static WolvenKit.RED4.Types.Enums;

namespace WolvenKit.RED4.Types
{
	public partial class ComputerMenuWidgetController : inkWidgetLogicController
	{
		[Ordinal(1)] 
		[RED("thumbnailsListWidget")] 
		public inkWidgetReference ThumbnailsListWidget
		{
			get => GetPropertyValue<inkWidgetReference>();
			set => SetPropertyValue<inkWidgetReference>(value);
		}

		[Ordinal(2)] 
		[RED("contentWidget")] 
		public inkWidgetReference ContentWidget
		{
			get => GetPropertyValue<inkWidgetReference>();
			set => SetPropertyValue<inkWidgetReference>(value);
		}

		[Ordinal(3)] 
		[RED("isInitialized")] 
		public CBool IsInitialized
		{
			get => GetPropertyValue<CBool>();
			set => SetPropertyValue<CBool>(value);
		}

		[Ordinal(4)] 
		[RED("fileWidgetsData")] 
		public CArray<SDocumentWidgetPackage> FileWidgetsData
		{
			get => GetPropertyValue<CArray<SDocumentWidgetPackage>>();
			set => SetPropertyValue<CArray<SDocumentWidgetPackage>>(value);
		}

		[Ordinal(5)] 
		[RED("fileThumbnailWidgetsData")] 
		public CArray<SDocumentThumbnailWidgetPackage> FileThumbnailWidgetsData
		{
			get => GetPropertyValue<CArray<SDocumentThumbnailWidgetPackage>>();
			set => SetPropertyValue<CArray<SDocumentThumbnailWidgetPackage>>(value);
		}

		public ComputerMenuWidgetController()
		{
			ThumbnailsListWidget = new inkWidgetReference();
			ContentWidget = new inkWidgetReference();
			FileWidgetsData = new();
			FileThumbnailWidgetsData = new();

			PostConstruct();
		}

		partial void PostConstruct();
	}
}
