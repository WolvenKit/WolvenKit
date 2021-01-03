using System.IO;
using WolvenKit.CR2W.Reflection;
using FastMember;
using static WolvenKit.CR2W.Types.Enums;

namespace WolvenKit.CR2W.Types
{
	[REDMeta]
	public class SPlayerCooldown : CVariable
	{
		[Ordinal(0)]  [RED("effectID")] public TweakDBID EffectID { get; set; }
		[Ordinal(1)]  [RED("instigatorID")] public TweakDBID InstigatorID { get; set; }

		public SPlayerCooldown(CR2WFile cr2w, CVariable parent, string name) : base(cr2w, parent, name) { }
	}
}
