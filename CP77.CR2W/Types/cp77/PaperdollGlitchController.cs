using System.IO;
using WolvenKit.CR2W.Reflection;
using FastMember;
using static WolvenKit.CR2W.Types.Enums;

namespace WolvenKit.CR2W.Types
{
	[REDMeta]
	public class PaperdollGlitchController : inkWidgetLogicController
	{
		[Ordinal(0)]  [RED("GlitchAnimationName")] public CName GlitchAnimationName { get; set; }
		[Ordinal(1)]  [RED("PaperdollGlichRoot")] public inkWidgetReference PaperdollGlichRoot { get; set; }

		public PaperdollGlitchController(CR2WFile cr2w, CVariable parent, string name) : base(cr2w, parent, name) { }
	}
}
