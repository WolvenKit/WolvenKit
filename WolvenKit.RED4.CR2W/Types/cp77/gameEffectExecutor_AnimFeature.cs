using WolvenKit.RED4.CR2W.Reflection;
using FastMember;
using static WolvenKit.RED4.CR2W.Types.Enums;

namespace WolvenKit.RED4.CR2W.Types
{
	[REDMeta]
	public class gameEffectExecutor_AnimFeature : gameEffectExecutor
	{
		[Ordinal(1)] [RED("key")] public CName Key { get; set; }
		[Ordinal(2)] [RED("animFeature")] public CHandle<animAnimFeature> AnimFeature { get; set; }
		[Ordinal(3)] [RED("applyTo")] public CEnum<gameEffectExecutor_AnimFeatureApplyTo> ApplyTo { get; set; }

		public gameEffectExecutor_AnimFeature(CR2WFile cr2w, CVariable parent, string name) : base(cr2w, parent, name) { }
	}
}
