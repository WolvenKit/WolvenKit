using WolvenKit.RED4.CR2W.Reflection;
using FastMember;
using static WolvenKit.RED4.CR2W.Types.Enums;

namespace WolvenKit.RED4.CR2W.Types
{
	[REDMeta]
	public class gameDamageSystem : gameIDamageSystem
	{
		[Ordinal(0)] [RED("previewTarget")] public previewTargetStruct PreviewTarget { get; set; }
		[Ordinal(1)] [RED("previewLock")] public CBool PreviewLock { get; set; }
		[Ordinal(2)] [RED("previewRWLockTemp")] public ScriptReentrantRWLock PreviewRWLockTemp { get; set; }

		public gameDamageSystem(CR2WFile cr2w, CVariable parent, string name) : base(cr2w, parent, name) { }
	}
}
