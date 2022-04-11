using static WolvenKit.RED4.Types.Enums;

namespace WolvenKit.RED4.Types
{
	[REDMeta]
	public partial class WardrobeUIGameController : gameuiMenuGameController
	{
		[Ordinal(3)] 
		[RED("tooltipsManagerRef")] 
		public inkWidgetReference TooltipsManagerRef
		{
			get => GetPropertyValue<inkWidgetReference>();
			set => SetPropertyValue<inkWidgetReference>(value);
		}

		[Ordinal(4)] 
		[RED("buttonHintsManagerRef")] 
		public inkWidgetReference ButtonHintsManagerRef
		{
			get => GetPropertyValue<inkWidgetReference>();
			set => SetPropertyValue<inkWidgetReference>(value);
		}

		[Ordinal(5)] 
		[RED("setEditorWidget")] 
		public inkWidgetReference SetEditorWidget
		{
			get => GetPropertyValue<inkWidgetReference>();
			set => SetPropertyValue<inkWidgetReference>(value);
		}

		[Ordinal(6)] 
		[RED("mainScreenWidget")] 
		public inkWidgetReference MainScreenWidget
		{
			get => GetPropertyValue<inkWidgetReference>();
			set => SetPropertyValue<inkWidgetReference>(value);
		}

		[Ordinal(7)] 
		[RED("setGridWidget")] 
		public inkCompoundWidgetReference SetGridWidget
		{
			get => GetPropertyValue<inkCompoundWidgetReference>();
			set => SetPropertyValue<inkCompoundWidgetReference>(value);
		}

		[Ordinal(8)] 
		[RED("menuEventDispatcher")] 
		public CWeakHandle<inkMenuEventDispatcher> MenuEventDispatcher
		{
			get => GetPropertyValue<CWeakHandle<inkMenuEventDispatcher>>();
			set => SetPropertyValue<CWeakHandle<inkMenuEventDispatcher>>(value);
		}

		[Ordinal(9)] 
		[RED("player")] 
		public CWeakHandle<PlayerPuppet> Player
		{
			get => GetPropertyValue<CWeakHandle<PlayerPuppet>>();
			set => SetPropertyValue<CWeakHandle<PlayerPuppet>>(value);
		}

		[Ordinal(10)] 
		[RED("setEditorController")] 
		public CWeakHandle<WardrobeSetEditorUIController> SetEditorController
		{
			get => GetPropertyValue<CWeakHandle<WardrobeSetEditorUIController>>();
			set => SetPropertyValue<CWeakHandle<WardrobeSetEditorUIController>>(value);
		}

		[Ordinal(11)] 
		[RED("isMainScreen")] 
		public CBool IsMainScreen
		{
			get => GetPropertyValue<CBool>();
			set => SetPropertyValue<CBool>(value);
		}

		[Ordinal(12)] 
		[RED("tooltipsManager")] 
		public CWeakHandle<gameuiTooltipsManager> TooltipsManager
		{
			get => GetPropertyValue<CWeakHandle<gameuiTooltipsManager>>();
			set => SetPropertyValue<CWeakHandle<gameuiTooltipsManager>>(value);
		}

		[Ordinal(13)] 
		[RED("buttonHintsController")] 
		public CWeakHandle<ButtonHints> ButtonHintsController
		{
			get => GetPropertyValue<CWeakHandle<ButtonHints>>();
			set => SetPropertyValue<CWeakHandle<ButtonHints>>(value);
		}

		[Ordinal(14)] 
		[RED("sets")] 
		public CArray<ClothingSet> Sets
		{
			get => GetPropertyValue<CArray<ClothingSet>>();
			set => SetPropertyValue<CArray<ClothingSet>>(value);
		}

		public WardrobeUIGameController()
		{
			TooltipsManagerRef = new();
			ButtonHintsManagerRef = new();
			SetEditorWidget = new();
			MainScreenWidget = new();
			SetGridWidget = new();
			Sets = new();
		}
	}
}
