using static WolvenKit.RED4.Types.Enums;

namespace WolvenKit.RED4.Types
{
	public partial class gameuiControllerSettingsGameController : gameuiMenuGameController
	{
		[Ordinal(3)] 
		[RED("defaultWidgets")] 
		public CArray<inkWidgetReference> DefaultWidgets
		{
			get => GetPropertyValue<CArray<inkWidgetReference>>();
			set => SetPropertyValue<CArray<inkWidgetReference>>(value);
		}

		[Ordinal(4)] 
		[RED("southpawWidgets")] 
		public CArray<inkWidgetReference> SouthpawWidgets
		{
			get => GetPropertyValue<CArray<inkWidgetReference>>();
			set => SetPropertyValue<CArray<inkWidgetReference>>(value);
		}

		[Ordinal(5)] 
		[RED("legacyWidgets")] 
		public CArray<inkWidgetReference> LegacyWidgets
		{
			get => GetPropertyValue<CArray<inkWidgetReference>>();
			set => SetPropertyValue<CArray<inkWidgetReference>>(value);
		}

		[Ordinal(6)] 
		[RED("generalInputPanel")] 
		public inkWidgetReference GeneralInputPanel
		{
			get => GetPropertyValue<inkWidgetReference>();
			set => SetPropertyValue<inkWidgetReference>(value);
		}

		[Ordinal(7)] 
		[RED("vehicleInputPanel")] 
		public inkWidgetReference VehicleInputPanel
		{
			get => GetPropertyValue<inkWidgetReference>();
			set => SetPropertyValue<inkWidgetReference>(value);
		}

		[Ordinal(8)] 
		[RED("vehicleCombatInputPanel")] 
		public inkWidgetReference VehicleCombatInputPanel
		{
			get => GetPropertyValue<inkWidgetReference>();
			set => SetPropertyValue<inkWidgetReference>(value);
		}

		[Ordinal(9)] 
		[RED("selectorWidget")] 
		public inkWidgetReference SelectorWidget
		{
			get => GetPropertyValue<inkWidgetReference>();
			set => SetPropertyValue<inkWidgetReference>(value);
		}

		[Ordinal(10)] 
		[RED("schemeLegacyRef")] 
		public inkWidgetReference SchemeLegacyRef
		{
			get => GetPropertyValue<inkWidgetReference>();
			set => SetPropertyValue<inkWidgetReference>(value);
		}

		[Ordinal(11)] 
		[RED("schemeAgileRef")] 
		public inkWidgetReference SchemeAgileRef
		{
			get => GetPropertyValue<inkWidgetReference>();
			set => SetPropertyValue<inkWidgetReference>(value);
		}

		[Ordinal(12)] 
		[RED("schemeAlternativeRef")] 
		public inkWidgetReference SchemeAlternativeRef
		{
			get => GetPropertyValue<inkWidgetReference>();
			set => SetPropertyValue<inkWidgetReference>(value);
		}

		[Ordinal(13)] 
		[RED("inputSettingSelectorRef")] 
		public inkWidgetReference InputSettingSelectorRef
		{
			get => GetPropertyValue<inkWidgetReference>();
			set => SetPropertyValue<inkWidgetReference>(value);
		}

		[Ordinal(14)] 
		[RED("inputSettingGroupName")] 
		public CName InputSettingGroupName
		{
			get => GetPropertyValue<CName>();
			set => SetPropertyValue<CName>(value);
		}

		[Ordinal(15)] 
		[RED("inputSettingVarName")] 
		public CName InputSettingVarName
		{
			get => GetPropertyValue<CName>();
			set => SetPropertyValue<CName>(value);
		}

		[Ordinal(16)] 
		[RED("buttonHintsManagerRef")] 
		public inkWidgetReference ButtonHintsManagerRef
		{
			get => GetPropertyValue<inkWidgetReference>();
			set => SetPropertyValue<inkWidgetReference>(value);
		}

		[Ordinal(17)] 
		[RED("buttonHintsController")] 
		public CWeakHandle<ButtonHints> ButtonHintsController
		{
			get => GetPropertyValue<CWeakHandle<ButtonHints>>();
			set => SetPropertyValue<CWeakHandle<ButtonHints>>(value);
		}

		[Ordinal(18)] 
		[RED("selectorCtrl")] 
		public CWeakHandle<inkListController> SelectorCtrl
		{
			get => GetPropertyValue<CWeakHandle<inkListController>>();
			set => SetPropertyValue<CWeakHandle<inkListController>>(value);
		}

		[Ordinal(19)] 
		[RED("inputPanel")] 
		public CArray<inkWidgetReference> InputPanel
		{
			get => GetPropertyValue<CArray<inkWidgetReference>>();
			set => SetPropertyValue<CArray<inkWidgetReference>>(value);
		}

		[Ordinal(20)] 
		[RED("currentTab")] 
		public CInt32 CurrentTab
		{
			get => GetPropertyValue<CInt32>();
			set => SetPropertyValue<CInt32>(value);
		}

		[Ordinal(21)] 
		[RED("inputSettingSelector")] 
		public CWeakHandle<SettingsSelectorControllerListString> InputSettingSelector
		{
			get => GetPropertyValue<CWeakHandle<SettingsSelectorControllerListString>>();
			set => SetPropertyValue<CWeakHandle<SettingsSelectorControllerListString>>(value);
		}

		[Ordinal(22)] 
		[RED("inputSettingsListener")] 
		public CHandle<InputSettingsVarListener> InputSettingsListener
		{
			get => GetPropertyValue<CHandle<InputSettingsVarListener>>();
			set => SetPropertyValue<CHandle<InputSettingsVarListener>>(value);
		}

		[Ordinal(23)] 
		[RED("settings")] 
		public CHandle<userSettingsUserSettings> Settings
		{
			get => GetPropertyValue<CHandle<userSettingsUserSettings>>();
			set => SetPropertyValue<CHandle<userSettingsUserSettings>>(value);
		}

		[Ordinal(24)] 
		[RED("inputSettingGroup")] 
		public CHandle<userSettingsGroup> InputSettingGroup
		{
			get => GetPropertyValue<CHandle<userSettingsGroup>>();
			set => SetPropertyValue<CHandle<userSettingsGroup>>(value);
		}

		[Ordinal(25)] 
		[RED("inputSettingVar")] 
		public CHandle<userSettingsVar> InputSettingVar
		{
			get => GetPropertyValue<CHandle<userSettingsVar>>();
			set => SetPropertyValue<CHandle<userSettingsVar>>(value);
		}

		public gameuiControllerSettingsGameController()
		{
			DefaultWidgets = new();
			SouthpawWidgets = new();
			LegacyWidgets = new();

			PostConstruct();
		}

		partial void PostConstruct();
	}
}
