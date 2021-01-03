using System.IO;
using WolvenKit.CR2W.Reflection;
using FastMember;
using static WolvenKit.CR2W.Types.Enums;

namespace WolvenKit.CR2W.Types
{
	[REDMeta]
	public class gamedeviceAction : redEvent
	{
		[Ordinal(0)]  [RED("actionName")] public CName ActionName { get; set; }
		[Ordinal(1)]  [RED("clearanceLevel")] public CInt32 ClearanceLevel { get; set; }
		[Ordinal(2)]  [RED("localizedObjectName")] public CString LocalizedObjectName { get; set; }

		public gamedeviceAction(CR2WFile cr2w, CVariable parent, string name) : base(cr2w, parent, name) { }
	}
}
