using WolvenKit.RED4.CR2W.Reflection;
using FastMember;
using static WolvenKit.RED4.CR2W.Types.Enums;

namespace WolvenKit.RED4.CR2W.Types
{
	[REDMeta]
	public class PaperdollGlitchController : inkWidgetLogicController
	{
		[Ordinal(1)] [RED("PaperdollGlichRoot")] public inkWidgetReference PaperdollGlichRoot { get; set; }
		[Ordinal(2)] [RED("GlitchAnimationName")] public CName GlitchAnimationName { get; set; }

		public PaperdollGlitchController(CR2WFile cr2w, CVariable parent, string name) : base(cr2w, parent, name) { }
	}
}
