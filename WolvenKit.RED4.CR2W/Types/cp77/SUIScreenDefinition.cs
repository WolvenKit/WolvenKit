using WolvenKit.RED4.CR2W.Reflection;
using FastMember;
using static WolvenKit.RED4.CR2W.Types.Enums;

namespace WolvenKit.RED4.CR2W.Types
{
	[REDMeta]
	public class SUIScreenDefinition : CVariable
	{
		[Ordinal(0)] [RED("screenDefinition")] public TweakDBID ScreenDefinition { get; set; }
		[Ordinal(1)] [RED("style")] public TweakDBID Style { get; set; }

		public SUIScreenDefinition(CR2WFile cr2w, CVariable parent, string name) : base(cr2w, parent, name) { }
	}
}
