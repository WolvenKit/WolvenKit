using static WolvenKit.RED4.Types.Enums;

namespace WolvenKit.RED4.Types
{
	[REDMeta]
	public partial class questFinalBoardsOpenSpeakerScreen_NodeType : questIUIManagerNodeType
	{
		[Ordinal(0)] 
		[RED("openSpeakerScreen")] 
		public CBool OpenSpeakerScreen
		{
			get => GetPropertyValue<CBool>();
			set => SetPropertyValue<CBool>(value);
		}

		[Ordinal(1)] 
		[RED("speakerName")] 
		public CString SpeakerName
		{
			get => GetPropertyValue<CString>();
			set => SetPropertyValue<CString>(value);
		}
	}
}
