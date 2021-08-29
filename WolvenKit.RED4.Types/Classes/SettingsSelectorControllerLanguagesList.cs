using static WolvenKit.RED4.Types.Enums;

namespace WolvenKit.RED4.Types
{
	[REDMeta]
	public partial class SettingsSelectorControllerLanguagesList : SettingsSelectorControllerListName
	{
		private inkWidgetReference _downloadButton;
		private inkTextWidgetReference _descriptionText;
		private CBool _isVoiceOverInstalled;
		private CInt32 _currentSetIndex;

		[Ordinal(22)] 
		[RED("downloadButton")] 
		public inkWidgetReference DownloadButton
		{
			get => GetProperty(ref _downloadButton);
			set => SetProperty(ref _downloadButton, value);
		}

		[Ordinal(23)] 
		[RED("descriptionText")] 
		public inkTextWidgetReference DescriptionText
		{
			get => GetProperty(ref _descriptionText);
			set => SetProperty(ref _descriptionText, value);
		}

		[Ordinal(24)] 
		[RED("isVoiceOverInstalled")] 
		public CBool IsVoiceOverInstalled
		{
			get => GetProperty(ref _isVoiceOverInstalled);
			set => SetProperty(ref _isVoiceOverInstalled, value);
		}

		[Ordinal(25)] 
		[RED("currentSetIndex")] 
		public CInt32 CurrentSetIndex
		{
			get => GetProperty(ref _currentSetIndex);
			set => SetProperty(ref _currentSetIndex, value);
		}
	}
}
