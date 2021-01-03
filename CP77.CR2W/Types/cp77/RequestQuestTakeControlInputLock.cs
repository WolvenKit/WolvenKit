using System.IO;
using WolvenKit.CR2W.Reflection;
using FastMember;
using static WolvenKit.CR2W.Types.Enums;

namespace WolvenKit.CR2W.Types
{
	[REDMeta]
	public class RequestQuestTakeControlInputLock : gameScriptableSystemRequest
	{
		[Ordinal(0)]  [RED("isChainForced")] public CBool IsChainForced { get; set; }
		[Ordinal(1)]  [RED("isLocked")] public CBool IsLocked { get; set; }

		public RequestQuestTakeControlInputLock(CR2WFile cr2w, CVariable parent, string name) : base(cr2w, parent, name) { }
	}
}
