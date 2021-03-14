using WolvenKit.RED4.CR2W.Reflection;
using FastMember;
using static WolvenKit.RED4.CR2W.Types.Enums;

namespace WolvenKit.RED4.CR2W.Types
{
	[REDMeta]
	public class gameEffectPostAction_Beam_RicochetPreviewPreviewEffect : CVariable
	{
		[Ordinal(0)] [RED("effect")] public raRef<worldEffect> Effect { get; set; }
		[Ordinal(1)] [RED("effectTag")] public CName EffectTag { get; set; }
		[Ordinal(2)] [RED("effectSnap")] public raRef<worldEffect> EffectSnap { get; set; }
		[Ordinal(3)] [RED("effectSnapTag")] public CName EffectSnapTag { get; set; }
		[Ordinal(4)] [RED("forwardOffset")] public CFloat ForwardOffset { get; set; }

		public gameEffectPostAction_Beam_RicochetPreviewPreviewEffect(CR2WFile cr2w, CVariable parent, string name) : base(cr2w, parent, name) { }
	}
}
