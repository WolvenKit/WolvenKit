using System.IO;
using WolvenKit.CR2W.Reflection;
using FastMember;
using static WolvenKit.CR2W.Types.Enums;

namespace WolvenKit.CR2W.Types
{
	[REDMeta]
	public class gameDamageSystem : gameIDamageSystem
	{
		[Ordinal(0)]  [RED("previewLock")] public CBool PreviewLock { get; set; }
		[Ordinal(1)]  [RED("previewRWLockTemp")] public ScriptReentrantRWLock PreviewRWLockTemp { get; set; }
		[Ordinal(2)]  [RED("previewTarget")] public previewTargetStruct PreviewTarget { get; set; }

		public gameDamageSystem(CR2WFile cr2w, CVariable parent, string name) : base(cr2w, parent, name) { }
	}
}
