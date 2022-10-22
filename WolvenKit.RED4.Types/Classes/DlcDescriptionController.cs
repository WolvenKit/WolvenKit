using static WolvenKit.RED4.Types.Enums;

namespace WolvenKit.RED4.Types
{
	public partial class DlcDescriptionController : inkWidgetLogicController
	{
		[Ordinal(1)] 
		[RED("titleRef")] 
		public inkTextWidgetReference TitleRef
		{
			get => GetPropertyValue<inkTextWidgetReference>();
			set => SetPropertyValue<inkTextWidgetReference>(value);
		}

		[Ordinal(2)] 
		[RED("descriptionRef")] 
		public inkTextWidgetReference DescriptionRef
		{
			get => GetPropertyValue<inkTextWidgetReference>();
			set => SetPropertyValue<inkTextWidgetReference>(value);
		}

		[Ordinal(3)] 
		[RED("guideRef")] 
		public inkTextWidgetReference GuideRef
		{
			get => GetPropertyValue<inkTextWidgetReference>();
			set => SetPropertyValue<inkTextWidgetReference>(value);
		}

		[Ordinal(4)] 
		[RED("imageRef")] 
		public inkImageWidgetReference ImageRef
		{
			get => GetPropertyValue<inkImageWidgetReference>();
			set => SetPropertyValue<inkImageWidgetReference>(value);
		}

		[Ordinal(5)] 
		[RED("settingSelectorRef")] 
		public inkWidgetReference SettingSelectorRef
		{
			get => GetPropertyValue<inkWidgetReference>();
			set => SetPropertyValue<inkWidgetReference>(value);
		}

		[Ordinal(6)] 
		[RED("settingSelector")] 
		public CWeakHandle<inkSettingsSelectorController> SettingSelector
		{
			get => GetPropertyValue<CWeakHandle<inkSettingsSelectorController>>();
			set => SetPropertyValue<CWeakHandle<inkSettingsSelectorController>>(value);
		}

		[Ordinal(7)] 
		[RED("settingsListener")] 
		public CHandle<DLCSettingsVarListener> SettingsListener
		{
			get => GetPropertyValue<CHandle<DLCSettingsVarListener>>();
			set => SetPropertyValue<CHandle<DLCSettingsVarListener>>(value);
		}

		[Ordinal(8)] 
		[RED("settingVar")] 
		public CHandle<userSettingsVar> SettingVar
		{
			get => GetPropertyValue<CHandle<userSettingsVar>>();
			set => SetPropertyValue<CHandle<userSettingsVar>>(value);
		}

		[Ordinal(9)] 
		[RED("isPreGame")] 
		public CBool IsPreGame
		{
			get => GetPropertyValue<CBool>();
			set => SetPropertyValue<CBool>(value);
		}

		public DlcDescriptionController()
		{
			TitleRef = new();
			DescriptionRef = new();
			GuideRef = new();
			ImageRef = new();
			SettingSelectorRef = new();

			PostConstruct();
		}

		partial void PostConstruct();
	}
}
