using System.IO;
using WolvenKit.CR2W.Reflection;
using FastMember;
using static WolvenKit.CR2W.Types.Enums;

namespace WolvenKit.CR2W.Types
{
	[REDMeta]
	public class SUIScreenDefinition : CVariable
	{
		[Ordinal(0)]  [RED("screenDefinition")] public TweakDBID ScreenDefinition { get; set; }
		[Ordinal(1)]  [RED("style")] public TweakDBID Style { get; set; }

		public SUIScreenDefinition(CR2WFile cr2w, CVariable parent, string name) : base(cr2w, parent, name) { }
	}
}
