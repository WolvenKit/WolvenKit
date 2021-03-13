using WolvenKit.RED4.CR2W.Reflection;
using FastMember;
using static WolvenKit.RED4.CR2W.Types.Enums;

namespace WolvenKit.RED4.CR2W.Types
{
	[REDMeta]
	public class EffectExecutor_ApplyEffector : gameEffectExecutor_Scripted
	{
		[Ordinal(1)] [RED("effector")] public TweakDBID Effector { get; set; }

		public EffectExecutor_ApplyEffector(CR2WFile cr2w, CVariable parent, string name) : base(cr2w, parent, name) { }
	}
}
