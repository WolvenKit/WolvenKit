using static WolvenKit.RED4.Types.Enums;

namespace WolvenKit.RED4.Types
{
	[REDMeta]
	public partial class questFinalBoardsOpenSpeakerScreen_NodeType : questIUIManagerNodeType
	{
		private CBool _openSpeakerScreen;
		private CString _speakerName;

		[Ordinal(0)] 
		[RED("openSpeakerScreen")] 
		public CBool OpenSpeakerScreen
		{
			get => GetProperty(ref _openSpeakerScreen);
			set => SetProperty(ref _openSpeakerScreen, value);
		}

		[Ordinal(1)] 
		[RED("speakerName")] 
		public CString SpeakerName
		{
			get => GetProperty(ref _speakerName);
			set => SetProperty(ref _speakerName, value);
		}
	}
}
