using static WolvenKit.RED4.Types.Enums;

namespace WolvenKit.RED4.Types
{
	public partial class TwintoneOverrideGameController : gameuiWidgetGameController
	{
		[Ordinal(2)] 
		[RED("overrideButtonHit")] 
		public inkWidgetReference OverrideButtonHit
		{
			get => GetPropertyValue<inkWidgetReference>();
			set => SetPropertyValue<inkWidgetReference>(value);
		}

		[Ordinal(3)] 
		[RED("backButtonHit")] 
		public inkWidgetReference BackButtonHit
		{
			get => GetPropertyValue<inkWidgetReference>();
			set => SetPropertyValue<inkWidgetReference>(value);
		}

		[Ordinal(4)] 
		[RED("templatePreviewContainer")] 
		public inkWidgetReference TemplatePreviewContainer
		{
			get => GetPropertyValue<inkWidgetReference>();
			set => SetPropertyValue<inkWidgetReference>(value);
		}

		[Ordinal(5)] 
		[RED("templatePreviewLibraryRef")] 
		public inkWidgetLibraryReference TemplatePreviewLibraryRef
		{
			get => GetPropertyValue<inkWidgetLibraryReference>();
			set => SetPropertyValue<inkWidgetLibraryReference>(value);
		}

		[Ordinal(6)] 
		[RED("currentTemplatePreview")] 
		public CWeakHandle<ColorTemplatePreviewDisplayController> CurrentTemplatePreview
		{
			get => GetPropertyValue<CWeakHandle<ColorTemplatePreviewDisplayController>>();
			set => SetPropertyValue<CWeakHandle<ColorTemplatePreviewDisplayController>>(value);
		}

		[Ordinal(7)] 
		[RED("overrideData")] 
		public CHandle<TwintoneOverrideData> OverrideData
		{
			get => GetPropertyValue<CHandle<TwintoneOverrideData>>();
			set => SetPropertyValue<CHandle<TwintoneOverrideData>>(value);
		}

		[Ordinal(8)] 
		[RED("player")] 
		public CWeakHandle<gameObject> Player
		{
			get => GetPropertyValue<CWeakHandle<gameObject>>();
			set => SetPropertyValue<CWeakHandle<gameObject>>(value);
		}

		[Ordinal(9)] 
		[RED("game")] 
		public ScriptGameInstance Game
		{
			get => GetPropertyValue<ScriptGameInstance>();
			set => SetPropertyValue<ScriptGameInstance>(value);
		}

		[Ordinal(10)] 
		[RED("templateToDelete")] 
		public VehicleVisualCustomizationTemplate TemplateToDelete
		{
			get => GetPropertyValue<VehicleVisualCustomizationTemplate>();
			set => SetPropertyValue<VehicleVisualCustomizationTemplate>(value);
		}

		public TwintoneOverrideGameController()
		{
			OverrideButtonHit = new inkWidgetReference();
			BackButtonHit = new inkWidgetReference();
			TemplatePreviewContainer = new inkWidgetReference();
			TemplatePreviewLibraryRef = new inkWidgetLibraryReference { WidgetLibrary = new inkWidgetLibraryResourceWrapper() };
			Game = new ScriptGameInstance();
			TemplateToDelete = new VehicleVisualCustomizationTemplate { GenericData = new GenericTemplatePersistentData(), UniqueData = new UniqueTemplateData { CustomMultilayers = new(), CustomDecals = new(), GlobalClearCoatOverrides = new vehicleVehicleClearCoatOverrides { Opacity = -1.000000F, CoatTintFwd = new CColor(), CoatTintSide = new CColor(), CoatTintFresnelBias = -1.000000F, CoatSpecularColor = new CColor(), CoatFresnelBias = -1.000000F }, PartsClearCoatOverrides = new() } };

			PostConstruct();
		}

		partial void PostConstruct();
	}
}
