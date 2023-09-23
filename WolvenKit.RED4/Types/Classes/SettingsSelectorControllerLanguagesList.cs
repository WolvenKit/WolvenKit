using static WolvenKit.RED4.Types.Enums;

namespace WolvenKit.RED4.Types
{
	public partial class SettingsSelectorControllerLanguagesList : SettingsSelectorControllerListName
	{
		[Ordinal(22)] 
		[RED("downloadButton")] 
		public inkWidgetReference DownloadButton
		{
			get => GetPropertyValue<inkWidgetReference>();
			set => SetPropertyValue<inkWidgetReference>(value);
		}

		[Ordinal(23)] 
		[RED("descriptionText")] 
		public inkTextWidgetReference DescriptionText
		{
			get => GetPropertyValue<inkTextWidgetReference>();
			set => SetPropertyValue<inkTextWidgetReference>(value);
		}

		[Ordinal(24)] 
		[RED("isVoiceOverInstalled")] 
		public CBool IsVoiceOverInstalled
		{
			get => GetPropertyValue<CBool>();
			set => SetPropertyValue<CBool>(value);
		}

		[Ordinal(25)] 
		[RED("currentSetIndex")] 
		public CInt32 CurrentSetIndex
		{
			get => GetPropertyValue<CInt32>();
			set => SetPropertyValue<CInt32>(value);
		}

		public SettingsSelectorControllerLanguagesList()
		{
			PostConstruct();
		}

		partial void PostConstruct();
	}
}
