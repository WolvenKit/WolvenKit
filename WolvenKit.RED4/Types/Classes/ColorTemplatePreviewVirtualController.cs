using static WolvenKit.RED4.Types.Enums;

namespace WolvenKit.RED4.Types
{
	public partial class ColorTemplatePreviewVirtualController : inkVirtualCompoundItemController
	{
		[Ordinal(18)] 
		[RED("widgetToSpawn")] 
		public CName WidgetToSpawn
		{
			get => GetPropertyValue<CName>();
			set => SetPropertyValue<CName>(value);
		}

		[Ordinal(19)] 
		[RED("wrappedData")] 
		public CHandle<WrappedTemplateData> WrappedData
		{
			get => GetPropertyValue<CHandle<WrappedTemplateData>>();
			set => SetPropertyValue<CHandle<WrappedTemplateData>>(value);
		}

		[Ordinal(20)] 
		[RED("spawnedWidget")] 
		public CWeakHandle<inkWidget> SpawnedWidget
		{
			get => GetPropertyValue<CWeakHandle<inkWidget>>();
			set => SetPropertyValue<CWeakHandle<inkWidget>>(value);
		}

		[Ordinal(21)] 
		[RED("templatePreview")] 
		public CWeakHandle<ColorTemplatePreviewDisplayController> TemplatePreview
		{
			get => GetPropertyValue<CWeakHandle<ColorTemplatePreviewDisplayController>>();
			set => SetPropertyValue<CWeakHandle<ColorTemplatePreviewDisplayController>>(value);
		}

		[Ordinal(22)] 
		[RED("templateToggled")] 
		public CBool TemplateToggled
		{
			get => GetPropertyValue<CBool>();
			set => SetPropertyValue<CBool>(value);
		}

		[Ordinal(23)] 
		[RED("templateSelected")] 
		public CBool TemplateSelected
		{
			get => GetPropertyValue<CBool>();
			set => SetPropertyValue<CBool>(value);
		}

		[Ordinal(24)] 
		[RED("canNavigate")] 
		public CBool CanNavigate
		{
			get => GetPropertyValue<CBool>();
			set => SetPropertyValue<CBool>(value);
		}

		[Ordinal(25)] 
		[RED("colorCorrectionEnabled")] 
		public CBool ColorCorrectionEnabled
		{
			get => GetPropertyValue<CBool>();
			set => SetPropertyValue<CBool>(value);
		}

		public ColorTemplatePreviewVirtualController()
		{
			CanNavigate = true;

			PostConstruct();
		}

		partial void PostConstruct();
	}
}
