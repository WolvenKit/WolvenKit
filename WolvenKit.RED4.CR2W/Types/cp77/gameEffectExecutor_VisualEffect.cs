using WolvenKit.RED4.CR2W.Reflection;
using FastMember;
using static WolvenKit.RED4.CR2W.Types.Enums;

namespace WolvenKit.RED4.CR2W.Types
{
	[REDMeta]
	public class gameEffectExecutor_VisualEffect : gameEffectExecutor
	{
		[Ordinal(1)] [RED("effect")] public raRef<worldEffect> Effect { get; set; }
		[Ordinal(2)] [RED("attached")] public CBool Attached { get; set; }
		[Ordinal(3)] [RED("breakLoopOnDetach")] public CBool BreakLoopOnDetach { get; set; }
		[Ordinal(4)] [RED("effectTag")] public CName EffectTag { get; set; }
		[Ordinal(5)] [RED("vectorEvaluator")] public CHandle<gameEffectVectorEvaluator> VectorEvaluator { get; set; }

		public gameEffectExecutor_VisualEffect(CR2WFile cr2w, CVariable parent, string name) : base(cr2w, parent, name) { }
	}
}
