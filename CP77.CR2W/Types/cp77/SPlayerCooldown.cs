using System.IO;
using CP77.CR2W.Reflection;
using FastMember;
using static CP77.CR2W.Types.Enums;

namespace CP77.CR2W.Types
{
	[REDMeta]
	public class SPlayerCooldown : CVariable
	{
		[Ordinal(0)] [RED("effectID")] public TweakDBID EffectID { get; set; }
		[Ordinal(1)] [RED("instigatorID")] public TweakDBID InstigatorID { get; set; }

		public SPlayerCooldown(CR2WFile cr2w, CVariable parent, string name) : base(cr2w, parent, name) { }
	}
}
