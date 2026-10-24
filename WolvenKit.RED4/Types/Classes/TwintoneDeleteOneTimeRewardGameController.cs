using static WolvenKit.RED4.Types.Enums;

namespace WolvenKit.RED4.Types
{
	public partial class TwintoneDeleteOneTimeRewardGameController : gameuiWidgetGameController
	{
		[Ordinal(2)] 
		[RED("deleteButtonHit")] 
		public inkWidgetReference DeleteButtonHit
		{
			get => GetPropertyValue<inkWidgetReference>();
			set => SetPropertyValue<inkWidgetReference>(value);
		}

		[Ordinal(3)] 
		[RED("cancelButtonHit")] 
		public inkWidgetReference CancelButtonHit
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
		[RED("deletionData")] 
		public CHandle<TwintoneDeletionData> DeletionData
		{
			get => GetPropertyValue<CHandle<TwintoneDeletionData>>();
			set => SetPropertyValue<CHandle<TwintoneDeletionData>>(value);
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

		[Ordinal(11)] 
		[RED("outroAnimProxy")] 
		public CHandle<inkanimProxy> OutroAnimProxy
		{
			get => GetPropertyValue<CHandle<inkanimProxy>>();
			set => SetPropertyValue<CHandle<inkanimProxy>>(value);
		}

		public TwintoneDeleteOneTimeRewardGameController()
		{
			DeleteButtonHit = new inkWidgetReference();
			CancelButtonHit = new inkWidgetReference();
			TemplatePreviewContainer = new inkWidgetReference();
			TemplatePreviewLibraryRef = new inkWidgetLibraryReference();
			Game = new ScriptGameInstance();
			TemplateToDelete = new VehicleVisualCustomizationTemplate();

			PostConstruct();
		}

		partial void PostConstruct();
	}
}
