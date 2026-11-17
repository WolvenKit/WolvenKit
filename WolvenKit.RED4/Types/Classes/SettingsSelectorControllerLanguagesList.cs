using static WolvenKit.RED4.Types.Enums;

namespace WolvenKit.RED4.Types
{
	public partial class SettingsSelectorControllerLanguagesList : SettingsSelectorControllerListName
	{
		[Ordinal(24)] 
		[RED("downloadButton")] 
		public inkWidgetReference DownloadButton
		{
			get => GetPropertyValue<inkWidgetReference>();
			set => SetPropertyValue<inkWidgetReference>(value);
		}

		[Ordinal(25)] 
		[RED("descriptionText")] 
		public inkTextWidgetReference DescriptionText
		{
			get => GetPropertyValue<inkTextWidgetReference>();
			set => SetPropertyValue<inkTextWidgetReference>(value);
		}

		[Ordinal(26)] 
		[RED("isVoiceOverInstalled")] 
		public CBool IsVoiceOverInstalled
		{
			get => GetPropertyValue<CBool>();
			set => SetPropertyValue<CBool>(value);
		}

		[Ordinal(27)] 
		[RED("isVoiceOverInstallEnabled")] 
		public CBool IsVoiceOverInstallEnabled
		{
			get => GetPropertyValue<CBool>();
			set => SetPropertyValue<CBool>(value);
		}

		[Ordinal(28)] 
		[RED("currentSetIndex")] 
		public CInt32 CurrentSetIndex
		{
			get => GetPropertyValue<CInt32>();
			set => SetPropertyValue<CInt32>(value);
		}

		[Ordinal(29)] 
		[RED("ctrl")] 
		public CWeakHandle<SettingsMainGameController> Ctrl
		{
			get => GetPropertyValue<CWeakHandle<SettingsMainGameController>>();
			set => SetPropertyValue<CWeakHandle<SettingsMainGameController>>(value);
		}

		public SettingsSelectorControllerLanguagesList()
		{
			DownloadButton = new inkWidgetReference();
			DescriptionText = new inkTextWidgetReference();

			PostConstruct();
		}

		partial void PostConstruct();
	}
}
