using System.IO;
using WolvenKit.CR2W.Reflection;
using FastMember;
using static WolvenKit.CR2W.Types.Enums;

namespace WolvenKit.CR2W.Types
{
	[REDMeta]
	public class gameEffectExecutor_AnimFeature : gameEffectExecutor
	{
		[Ordinal(0)]  [RED("animFeature")] public CHandle<animAnimFeature> AnimFeature { get; set; }
		[Ordinal(1)]  [RED("applyTo")] public CEnum<gameEffectExecutor_AnimFeatureApplyTo> ApplyTo { get; set; }
		[Ordinal(2)]  [RED("key")] public CName Key { get; set; }

		public gameEffectExecutor_AnimFeature(CR2WFile cr2w, CVariable parent, string name) : base(cr2w, parent, name) { }
	}
}
