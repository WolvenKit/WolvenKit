using static WolvenKit.RED4.Types.Enums;

namespace WolvenKit.RED4.Types
{
	public partial class TwintoneTemplateGridController : inkGridController
	{
		[Ordinal(12)] 
		[RED("templatesDataSource")] 
		public CHandle<inkScriptableDataSourceWrapper> TemplatesDataSource
		{
			get => GetPropertyValue<CHandle<inkScriptableDataSourceWrapper>>();
			set => SetPropertyValue<CHandle<inkScriptableDataSourceWrapper>>(value);
		}

		[Ordinal(13)] 
		[RED("templatesDataView")] 
		public CHandle<inkScriptableDataViewWrapper> TemplatesDataView
		{
			get => GetPropertyValue<CHandle<inkScriptableDataViewWrapper>>();
			set => SetPropertyValue<CHandle<inkScriptableDataViewWrapper>>(value);
		}

		[Ordinal(14)] 
		[RED("templatesDataClassifier")] 
		public CHandle<VehicleVisualCustomizationTemplateClassifier> TemplatesDataClassifier
		{
			get => GetPropertyValue<CHandle<VehicleVisualCustomizationTemplateClassifier>>();
			set => SetPropertyValue<CHandle<VehicleVisualCustomizationTemplateClassifier>>(value);
		}

		[Ordinal(15)] 
		[RED("templatePositionProvider")] 
		public CHandle<VehicleVisualCustomizationTemplatePositionProvider> TemplatePositionProvider
		{
			get => GetPropertyValue<CHandle<VehicleVisualCustomizationTemplatePositionProvider>>();
			set => SetPropertyValue<CHandle<VehicleVisualCustomizationTemplatePositionProvider>>(value);
		}

		[Ordinal(16)] 
		[RED("player")] 
		public CWeakHandle<PlayerPuppet> Player
		{
			get => GetPropertyValue<CWeakHandle<PlayerPuppet>>();
			set => SetPropertyValue<CWeakHandle<PlayerPuppet>>(value);
		}

		[Ordinal(17)] 
		[RED("toggledController")] 
		public CWeakHandle<ColorTemplatePreviewVirtualController> ToggledController
		{
			get => GetPropertyValue<CWeakHandle<ColorTemplatePreviewVirtualController>>();
			set => SetPropertyValue<CWeakHandle<ColorTemplatePreviewVirtualController>>(value);
		}

		[Ordinal(18)] 
		[RED("selectedController")] 
		public CWeakHandle<ColorTemplatePreviewVirtualController> SelectedController
		{
			get => GetPropertyValue<CWeakHandle<ColorTemplatePreviewVirtualController>>();
			set => SetPropertyValue<CWeakHandle<ColorTemplatePreviewVirtualController>>(value);
		}

		[Ordinal(19)] 
		[RED("canNavigate")] 
		public CBool CanNavigate
		{
			get => GetPropertyValue<CBool>();
			set => SetPropertyValue<CBool>(value);
		}

		[Ordinal(20)] 
		[RED("colorCorrectionEnabled")] 
		public CBool ColorCorrectionEnabled
		{
			get => GetPropertyValue<CBool>();
			set => SetPropertyValue<CBool>(value);
		}

		[Ordinal(21)] 
		[RED("enabled")] 
		public CBool Enabled
		{
			get => GetPropertyValue<CBool>();
			set => SetPropertyValue<CBool>(value);
		}

		public TwintoneTemplateGridController()
		{
			CanNavigate = true;
			Enabled = true;

			PostConstruct();
		}

		partial void PostConstruct();
	}
}
