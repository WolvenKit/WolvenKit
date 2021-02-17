using CP77.CR2W.Reflection;
using FastMember;
using static CP77.CR2W.Types.Enums;

namespace CP77.CR2W.Types
{
	[REDMeta]
	public class inkHoldControllerActionData : inkUserData
	{
		[Ordinal(0)] [RED("actionName")] public CName ActionName { get; set; }

		public inkHoldControllerActionData(CR2WFile cr2w, CVariable parent, string name) : base(cr2w, parent, name) { }
	}
}
