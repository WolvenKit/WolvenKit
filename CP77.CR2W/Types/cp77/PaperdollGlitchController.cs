using System.IO;
using CP77.CR2W.Reflection;
using FastMember;
using static CP77.CR2W.Types.Enums;

namespace CP77.CR2W.Types
{
	[REDMeta]
	public class PaperdollGlitchController : inkWidgetLogicController
	{
		[Ordinal(1)] [RED("PaperdollGlichRoot")] public inkWidgetReference PaperdollGlichRoot { get; set; }
		[Ordinal(2)] [RED("GlitchAnimationName")] public CName GlitchAnimationName { get; set; }

		public PaperdollGlitchController(CR2WFile cr2w, CVariable parent, string name) : base(cr2w, parent, name) { }
	}
}
