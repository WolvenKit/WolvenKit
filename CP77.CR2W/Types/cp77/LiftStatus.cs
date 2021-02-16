using CP77.CR2W.Reflection;
using FastMember;
using static CP77.CR2W.Types.Enums;

namespace CP77.CR2W.Types
{
	[REDMeta]
	public class LiftStatus : BaseDeviceStatus
	{
		[Ordinal(26)] [RED("libraryName")] public CName LibraryName { get; set; }

		public LiftStatus(CR2WFile cr2w, CVariable parent, string name) : base(cr2w, parent, name) { }
	}
}
