using System.IO;
using CP77.CR2W.Reflection;
using FastMember;
using static CP77.CR2W.Types.Enums;

namespace CP77.CR2W.Types
{
	[REDMeta]
	public class gameEffectPostAction_BeamVFX_Custom : gameEffectPostAction_BeamVFX
	{
		[Ordinal(0)] [RED("effect")] public raRef<worldEffect> Effect { get; set; }
		[Ordinal(1)] [RED("attached")] public CBool Attached { get; set; }
		[Ordinal(2)] [RED("breakLoopOnDetach")] public CBool BreakLoopOnDetach { get; set; }
		[Ordinal(3)] [RED("invert")] public CBool Invert { get; set; }
		[Ordinal(4)] [RED("effectTag")] public CName EffectTag { get; set; }

		public gameEffectPostAction_BeamVFX_Custom(CR2WFile cr2w, CVariable parent, string name) : base(cr2w, parent, name) { }
	}
}
