using CP77.CR2W.Reflection;
using FastMember;
using static CP77.CR2W.Types.Enums;

namespace CP77.CR2W.Types
{
	[REDMeta]
	public class gameEffectAction_TerminateChildEffect : gameEffectAction
	{
		[Ordinal(0)] [RED("effectTag")] public CName EffectTag { get; set; }

		public gameEffectAction_TerminateChildEffect(CR2WFile cr2w, CVariable parent, string name) : base(cr2w, parent, name) { }
	}
}
