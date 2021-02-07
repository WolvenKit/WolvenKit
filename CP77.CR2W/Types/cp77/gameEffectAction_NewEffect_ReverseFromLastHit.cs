using System.IO;
using CP77.CR2W.Reflection;
using FastMember;
using static CP77.CR2W.Types.Enums;

namespace CP77.CR2W.Types
{
	[REDMeta]
	public class gameEffectAction_NewEffect_ReverseFromLastHit : gameEffectPostAction
	{
		[Ordinal(0)]  [RED("tagInThisFile")] public CName TagInThisFile { get; set; }
		[Ordinal(1)]  [RED("forwardOffset")] public CFloat ForwardOffset { get; set; }
		[Ordinal(2)]  [RED("childEffect")] public CBool ChildEffect { get; set; }
		[Ordinal(3)]  [RED("childEffectTag")] public CName ChildEffectTag { get; set; }

		public gameEffectAction_NewEffect_ReverseFromLastHit(CR2WFile cr2w, CVariable parent, string name) : base(cr2w, parent, name) { }
	}
}
