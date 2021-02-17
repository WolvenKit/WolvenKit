using CP77.CR2W.Reflection;
using FastMember;
using static CP77.CR2W.Types.Enums;

namespace CP77.CR2W.Types
{
	[REDMeta]
	public class gameuiEntityPreviewGameController : gameuiMenuGameController
	{
		[Ordinal(3)] [RED("entityToPreview")] public raRef<entEntityTemplate> EntityToPreview { get; set; }

		public gameuiEntityPreviewGameController(CR2WFile cr2w, CVariable parent, string name) : base(cr2w, parent, name) { }
	}
}
