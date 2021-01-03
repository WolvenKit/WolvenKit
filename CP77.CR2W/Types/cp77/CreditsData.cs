using System.IO;
using WolvenKit.CR2W.Reflection;
using FastMember;
using static WolvenKit.CR2W.Types.Enums;

namespace WolvenKit.CR2W.Types
{
	[REDMeta]
	public class CreditsData : inkUserData
	{
		[Ordinal(0)]  [RED("isFinalBoards")] public CBool IsFinalBoards { get; set; }
		[Ordinal(1)]  [RED("showRewardPrompt")] public CBool ShowRewardPrompt { get; set; }

		public CreditsData(CR2WFile cr2w, CVariable parent, string name) : base(cr2w, parent, name) { }
	}
}
