using WolvenKit.RED4.CR2W.Reflection;
using FastMember;
using static WolvenKit.RED4.CR2W.Types.Enums;

namespace WolvenKit.RED4.CR2W.Types
{
	[REDMeta]
	public class gameuiUnlockableProgram : CVariable
	{
		[Ordinal(0)] [RED("name")] public CName Name { get; set; }
		[Ordinal(1)] [RED("note")] public CName Note { get; set; }
		[Ordinal(2)] [RED("isFulfilled")] public CBool IsFulfilled { get; set; }
		[Ordinal(3)] [RED("programTweakID")] public TweakDBID ProgramTweakID { get; set; }
		[Ordinal(4)] [RED("iconTweakID")] public TweakDBID IconTweakID { get; set; }
		[Ordinal(5)] [RED("hidden")] public CBool Hidden { get; set; }

		public gameuiUnlockableProgram(CR2WFile cr2w, CVariable parent, string name) : base(cr2w, parent, name) { }
	}
}
