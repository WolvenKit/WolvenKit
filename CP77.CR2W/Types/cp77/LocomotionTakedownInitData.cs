using System.IO;
using CP77.CR2W.Reflection;
using FastMember;
using static CP77.CR2W.Types.Enums;

namespace CP77.CR2W.Types
{
	[REDMeta]
	public class LocomotionTakedownInitData : IScriptable
	{
		[Ordinal(0)]  [RED("target")] public wCHandle<gameObject> Target { get; set; }
		[Ordinal(1)]  [RED("slideTime")] public CFloat SlideTime { get; set; }
		[Ordinal(2)]  [RED("actionName")] public CName ActionName { get; set; }

		public LocomotionTakedownInitData(CR2WFile cr2w, CVariable parent, string name) : base(cr2w, parent, name) { }
	}
}
