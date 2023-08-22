using static WolvenKit.RED4.Types.Enums;

namespace WolvenKit.RED4.Types
{
	public partial class PatchSettingsController : inkWidgetLogicController
	{
		[Ordinal(1)] 
		[RED("settingsGroupName")] 
		public CName SettingsGroupName
		{
			get => GetPropertyValue<CName>();
			set => SetPropertyValue<CName>(value);
		}

		[Ordinal(2)] 
		[RED("settingsVarName")] 
		public CName SettingsVarName
		{
			get => GetPropertyValue<CName>();
			set => SetPropertyValue<CName>(value);
		}

		[Ordinal(3)] 
		[RED("settingsVarControlWidget")] 
		public inkWidgetReference SettingsVarControlWidget
		{
			get => GetPropertyValue<inkWidgetReference>();
			set => SetPropertyValue<inkWidgetReference>(value);
		}

		[Ordinal(4)] 
		[RED("settingsVarController")] 
		public CWeakHandle<inkSettingsSelectorController> SettingsVarController
		{
			get => GetPropertyValue<CWeakHandle<inkSettingsSelectorController>>();
			set => SetPropertyValue<CWeakHandle<inkSettingsSelectorController>>(value);
		}

		[Ordinal(5)] 
		[RED("settingsListener")] 
		public CHandle<PatchSettingsControllerListener> SettingsListener
		{
			get => GetPropertyValue<CHandle<PatchSettingsControllerListener>>();
			set => SetPropertyValue<CHandle<PatchSettingsControllerListener>>(value);
		}

		public PatchSettingsController()
		{
			SettingsVarControlWidget = new inkWidgetReference();

			PostConstruct();
		}

		partial void PostConstruct();
	}
}
