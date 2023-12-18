using static WolvenKit.RED4.Types.Enums;

namespace WolvenKit.RED4.Types
{
	public partial class SettingsSelectorControllerLanguagesList : SettingsSelectorControllerListName
	{
		[Ordinal(23)] 
		[RED("downloadButton")] 
		public inkWidgetReference DownloadButton
		{
			get => GetPropertyValue<inkWidgetReference>();
			set => SetPropertyValue<inkWidgetReference>(value);
		}

		[Ordinal(24)] 
		[RED("descriptionText")] 
		public inkTextWidgetReference DescriptionText
		{
			get => GetPropertyValue<inkTextWidgetReference>();
			set => SetPropertyValue<inkTextWidgetReference>(value);
		}

		[Ordinal(25)] 
		[RED("isVoiceOverInstalled")] 
		public CBool IsVoiceOverInstalled
		{
			get => GetPropertyValue<CBool>();
			set => SetPropertyValue<CBool>(value);
		}

		[Ordinal(26)] 
		[RED("currentSetIndex")] 
		public CInt32 CurrentSetIndex
		{
			get => GetPropertyValue<CInt32>();
			set => SetPropertyValue<CInt32>(value);
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
