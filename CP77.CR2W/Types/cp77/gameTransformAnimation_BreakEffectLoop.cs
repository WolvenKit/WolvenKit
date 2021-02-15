using System.IO;
using CP77.CR2W.Reflection;
using FastMember;
using static CP77.CR2W.Types.Enums;

namespace CP77.CR2W.Types
{
	[REDMeta]
	public class gameTransformAnimation_BreakEffectLoop : gameTransformAnimation_Effects
	{
		[Ordinal(0)] [RED("effectTag")] public CName EffectTag { get; set; }

		public gameTransformAnimation_BreakEffectLoop(CR2WFile cr2w, CVariable parent, string name) : base(cr2w, parent, name) { }
	}
}
