using CP77.CR2W.Reflection;
using FastMember;
using static CP77.CR2W.Types.Enums;

namespace CP77.CR2W.Types
{
	[REDMeta]
	public class questInt32ValueWrapper : CVariable
	{
		[Ordinal(0)] [RED("valueProvider")] public CHandle<questIInt32ValueProvider> ValueProvider { get; set; }

		public questInt32ValueWrapper(CR2WFile cr2w, CVariable parent, string name) : base(cr2w, parent, name) { }
	}
}
