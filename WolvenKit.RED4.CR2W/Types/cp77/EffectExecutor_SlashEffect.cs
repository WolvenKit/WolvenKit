using WolvenKit.RED4.CR2W.Reflection;
using FastMember;
using static WolvenKit.RED4.CR2W.Types.Enums;

namespace WolvenKit.RED4.CR2W.Types
{
	[REDMeta]
	public class EffectExecutor_SlashEffect : gameEffectExecutor_Scripted
	{
		[Ordinal(1)] [RED("entries")] public CArray<EffectExecutor_SlashEffect_Entry> Entries { get; set; }

		public EffectExecutor_SlashEffect(CR2WFile cr2w, CVariable parent, string name) : base(cr2w, parent, name) { }
	}
}
