using System.IO;
using WolvenKit.CR2W.Reflection;
using FastMember;
using static WolvenKit.CR2W.Types.Enums;

namespace WolvenKit.CR2W.Types
{
	[REDMeta]
	public class ExplosiveDeviceResourceDefinition : CVariable
	{
		[Ordinal(0)]  [RED("additionalGameEffectType")] public CEnum<EExplosiveAdditionalGameEffectType> AdditionalGameEffectType { get; set; }
		[Ordinal(1)]  [RED("damageType")] public TweakDBID DamageType { get; set; }
		[Ordinal(2)]  [RED("dontHighlightOnLookat")] public CBool DontHighlightOnLookat { get; set; }
		[Ordinal(3)]  [RED("executionDelay")] public CFloat ExecutionDelay { get; set; }
		[Ordinal(4)]  [RED("vfxEventNamesOnExplosion")] public CArray<CName> VfxEventNamesOnExplosion { get; set; }
		[Ordinal(5)]  [RED("vfxResource")] public gameFxResource VfxResource { get; set; }
		[Ordinal(6)]  [RED("vfxResourceOnFirstHit")] public CArray<gameFxResource> VfxResourceOnFirstHit { get; set; }

		public ExplosiveDeviceResourceDefinition(CR2WFile cr2w, CVariable parent, string name) : base(cr2w, parent, name) { }
	}
}
