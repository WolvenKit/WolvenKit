using System.IO;
using CP77.CR2W.Reflection;
using FastMember;
using static CP77.CR2W.Types.Enums;

namespace CP77.CR2W.Types
{
	[REDMeta]
	public class gameEffectExecutor_TerminateGameEffect : gameEffectExecutor
	{
		[Ordinal(0)]  [RED("onlyWithPlayerInstigator")] public CBool OnlyWithPlayerInstigator { get; set; }

		public gameEffectExecutor_TerminateGameEffect(CR2WFile cr2w, CVariable parent, string name) : base(cr2w, parent, name) { }
	}
}
