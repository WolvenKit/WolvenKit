using System.IO;
using CP77.CR2W.Reflection;
using FastMember;
using static CP77.CR2W.Types.Enums;

namespace CP77.CR2W.Types
{
	[REDMeta]
	public class scnRidResourceHandler : CVariable
	{
		[Ordinal(0)]  [RED("id")] public scnRidResourceId Id { get; set; }
		[Ordinal(1)]  [RED("ridResource")] public rRef<scnRidResource> RidResource { get; set; }

		public scnRidResourceHandler(CR2WFile cr2w, CVariable parent, string name) : base(cr2w, parent, name) { }
	}
}
