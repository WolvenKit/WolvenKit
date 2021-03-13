using WolvenKit.RED4.CR2W.Reflection;
using FastMember;
using static WolvenKit.RED4.CR2W.Types.Enums;

namespace WolvenKit.RED4.CR2W.Types
{
	[REDMeta]
	public class questFinalBoardsOpenSpeakerScreen_NodeType : questIUIManagerNodeType
	{
		[Ordinal(0)] [RED("openSpeakerScreen")] public CBool OpenSpeakerScreen { get; set; }
		[Ordinal(1)] [RED("speakerName")] public CString SpeakerName { get; set; }

		public questFinalBoardsOpenSpeakerScreen_NodeType(CR2WFile cr2w, CVariable parent, string name) : base(cr2w, parent, name) { }
	}
}
