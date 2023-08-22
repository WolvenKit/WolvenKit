using static WolvenKit.RED4.Types.Enums;

namespace WolvenKit.RED4.Types
{
	public partial class PatchNotesGameController : gameuiMenuGameController
	{
		[Ordinal(3)] 
		[RED("buttonHintsRef")] 
		public inkWidgetReference ButtonHintsRef
		{
			get => GetPropertyValue<inkWidgetReference>();
			set => SetPropertyValue<inkWidgetReference>(value);
		}

		[Ordinal(4)] 
		[RED("animationName")] 
		public CName AnimationName
		{
			get => GetPropertyValue<CName>();
			set => SetPropertyValue<CName>(value);
		}

		[Ordinal(5)] 
		[RED("confirmBtn")] 
		public inkWidgetReference ConfirmBtn
		{
			get => GetPropertyValue<inkWidgetReference>();
			set => SetPropertyValue<inkWidgetReference>(value);
		}

		[Ordinal(6)] 
		[RED("selectorRef")] 
		public inkWidgetReference SelectorRef
		{
			get => GetPropertyValue<inkWidgetReference>();
			set => SetPropertyValue<inkWidgetReference>(value);
		}

		[Ordinal(7)] 
		[RED("patchImageRef")] 
		public inkImageWidgetReference PatchImageRef
		{
			get => GetPropertyValue<inkImageWidgetReference>();
			set => SetPropertyValue<inkImageWidgetReference>(value);
		}

		[Ordinal(8)] 
		[RED("platformSpecificNotes")] 
		public CArray<inkWidgetReference> PlatformSpecificNotes
		{
			get => GetPropertyValue<CArray<inkWidgetReference>>();
			set => SetPropertyValue<CArray<inkWidgetReference>>(value);
		}

		[Ordinal(9)] 
		[RED("uiSystem")] 
		public CHandle<gameuiGameSystemUI> UiSystem
		{
			get => GetPropertyValue<CHandle<gameuiGameSystemUI>>();
			set => SetPropertyValue<CHandle<gameuiGameSystemUI>>(value);
		}

		[Ordinal(10)] 
		[RED("menuEventDispatcher")] 
		public CWeakHandle<inkMenuEventDispatcher> MenuEventDispatcher
		{
			get => GetPropertyValue<CWeakHandle<inkMenuEventDispatcher>>();
			set => SetPropertyValue<CWeakHandle<inkMenuEventDispatcher>>(value);
		}

		[Ordinal(11)] 
		[RED("animProxy")] 
		public CHandle<inkanimProxy> AnimProxy
		{
			get => GetPropertyValue<CHandle<inkanimProxy>>();
			set => SetPropertyValue<CHandle<inkanimProxy>>(value);
		}

		[Ordinal(12)] 
		[RED("isInputBlocked")] 
		public CBool IsInputBlocked
		{
			get => GetPropertyValue<CBool>();
			set => SetPropertyValue<CBool>(value);
		}

		[Ordinal(13)] 
		[RED("contentList")] 
		public CArray<inkCompoundWidgetReference> ContentList
		{
			get => GetPropertyValue<CArray<inkCompoundWidgetReference>>();
			set => SetPropertyValue<CArray<inkCompoundWidgetReference>>(value);
		}

		[Ordinal(14)] 
		[RED("atlasParts")] 
		public CArray<CName> AtlasParts
		{
			get => GetPropertyValue<CArray<CName>>();
			set => SetPropertyValue<CArray<CName>>(value);
		}

		[Ordinal(15)] 
		[RED("labelsList")] 
		public CArray<CString> LabelsList
		{
			get => GetPropertyValue<CArray<CString>>();
			set => SetPropertyValue<CArray<CString>>(value);
		}

		[Ordinal(16)] 
		[RED("selectedIndex")] 
		public CInt32 SelectedIndex
		{
			get => GetPropertyValue<CInt32>();
			set => SetPropertyValue<CInt32>(value);
		}

		[Ordinal(17)] 
		[RED("contentPatchRef_1500")] 
		public inkCompoundWidgetReference ContentPatchRef_1500
		{
			get => GetPropertyValue<inkCompoundWidgetReference>();
			set => SetPropertyValue<inkCompoundWidgetReference>(value);
		}

		[Ordinal(18)] 
		[RED("contentPatchRef_1600")] 
		public inkCompoundWidgetReference ContentPatchRef_1600
		{
			get => GetPropertyValue<inkCompoundWidgetReference>();
			set => SetPropertyValue<inkCompoundWidgetReference>(value);
		}

		[Ordinal(19)] 
		[RED("contentPatchAtlasPart_1500")] 
		public CName ContentPatchAtlasPart_1500
		{
			get => GetPropertyValue<CName>();
			set => SetPropertyValue<CName>(value);
		}

		[Ordinal(20)] 
		[RED("contentPatchAtlasPart_1600")] 
		public CName ContentPatchAtlasPart_1600
		{
			get => GetPropertyValue<CName>();
			set => SetPropertyValue<CName>(value);
		}

		[Ordinal(21)] 
		[RED("tabsRef")] 
		public inkWidgetReference TabsRef
		{
			get => GetPropertyValue<inkWidgetReference>();
			set => SetPropertyValue<inkWidgetReference>(value);
		}

		[Ordinal(22)] 
		[RED("tabsController")] 
		public CWeakHandle<TabRadioGroup> TabsController
		{
			get => GetPropertyValue<CWeakHandle<TabRadioGroup>>();
			set => SetPropertyValue<CWeakHandle<TabRadioGroup>>(value);
		}

		[Ordinal(23)] 
		[RED("cloudSaveSettingsBlockRef")] 
		public inkCompoundWidgetReference CloudSaveSettingsBlockRef
		{
			get => GetPropertyValue<inkCompoundWidgetReference>();
			set => SetPropertyValue<inkCompoundWidgetReference>(value);
		}

		[Ordinal(24)] 
		[RED("cloudSaveSettingsBlock")] 
		public CWeakHandle<PatchSettingsController> CloudSaveSettingsBlock
		{
			get => GetPropertyValue<CWeakHandle<PatchSettingsController>>();
			set => SetPropertyValue<CWeakHandle<PatchSettingsController>>(value);
		}

		public PatchNotesGameController()
		{
			ButtonHintsRef = new inkWidgetReference();
			AnimationName = "intro";
			ConfirmBtn = new inkWidgetReference();
			SelectorRef = new inkWidgetReference();
			PatchImageRef = new inkImageWidgetReference();
			PlatformSpecificNotes = new();
			IsInputBlocked = true;
			ContentList = new();
			AtlasParts = new();
			LabelsList = new();
			ContentPatchRef_1500 = new inkCompoundWidgetReference();
			ContentPatchRef_1600 = new inkCompoundWidgetReference();
			TabsRef = new inkWidgetReference();
			CloudSaveSettingsBlockRef = new inkCompoundWidgetReference();

			PostConstruct();
		}

		partial void PostConstruct();
	}
}
