using WolvenKit.RED4.CR2W.Reflection;
using FastMember;
using static WolvenKit.RED4.CR2W.Types.Enums;

namespace WolvenKit.RED4.CR2W.Types
{
	[REDMeta]
	public class Example_FxSpawning : gameScriptableComponent
	{
		[Ordinal(5)] [RED("effect")] public gameFxResource Effect { get; set; }
		[Ordinal(6)] [RED("effectBeam")] public gameFxResource EffectBeam { get; set; }

		public Example_FxSpawning(CR2WFile cr2w, CVariable parent, string name) : base(cr2w, parent, name) { }
	}
}
