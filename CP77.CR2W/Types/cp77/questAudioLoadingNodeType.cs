using CP77.CR2W.Reflection;
using FastMember;
using static CP77.CR2W.Types.Enums;

namespace CP77.CR2W.Types
{
	[REDMeta]
	public class questAudioLoadingNodeType : questIAudioNodeType
	{
		[Ordinal(0)] [RED("banksToLoad")] public CArray<audioSoundBankStruct> BanksToLoad { get; set; }
		[Ordinal(1)] [RED("banksToUnload")] public CArray<audioSoundBankStruct> BanksToUnload { get; set; }
		[Ordinal(2)] [RED("waitOnLoad")] public CBool WaitOnLoad { get; set; }
		[Ordinal(3)] [RED("description")] public CString Description { get; set; }

		public questAudioLoadingNodeType(CR2WFile cr2w, CVariable parent, string name) : base(cr2w, parent, name) { }
	}
}
