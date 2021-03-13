using CP77.CR2W.Reflection;
using FastMember;
using static CP77.CR2W.Types.Enums;

namespace CP77.CR2W.Types
{
	[REDMeta]
	public class PreviousMenuData : IScriptable
	{
		[Ordinal(0)] [RED("openMenuRequest")] public CHandle<OpenMenuRequest> OpenMenuRequest { get; set; }

		public PreviousMenuData(CR2WFile cr2w, CVariable parent, string name) : base(cr2w, parent, name) { }
	}
}
