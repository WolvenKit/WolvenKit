using System.IO;
using WolvenKit.CR2W.Reflection;
using FastMember;
using static WolvenKit.CR2W.Types.Enums;

namespace WolvenKit.CR2W.Types
{
	[REDMeta]
	public class EffectExecutor_SlashEffect : gameEffectExecutor_Scripted
	{
		[Ordinal(0)]  [RED("entries")] public CArray<EffectExecutor_SlashEffect_Entry> Entries { get; set; }

		public EffectExecutor_SlashEffect(CR2WFile cr2w, CVariable parent, string name) : base(cr2w, parent, name) { }
	}
}
