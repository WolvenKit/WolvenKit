using WolvenKit.RED4.CR2W.Reflection;
using FastMember;
using static WolvenKit.RED4.CR2W.Types.Enums;

namespace WolvenKit.RED4.CR2W.Types
{
	[REDMeta]
	public class questFinalBoardsOpenSpeakerScreen_NodeType : questIUIManagerNodeType
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

		public questFinalBoardsOpenSpeakerScreen_NodeType(CR2WFile cr2w, CVariable parent, string name) : base(cr2w, parent, name) { }
	}
}
