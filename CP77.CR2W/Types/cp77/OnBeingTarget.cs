using System.IO;
using CP77.CR2W.Reflection;
using FastMember;
using static CP77.CR2W.Types.Enums;

namespace CP77.CR2W.Types
{
	[REDMeta]
	public class OnBeingTarget : redEvent
	{
		[Ordinal(0)]  [RED("noLongerTarget")] public CBool NoLongerTarget { get; set; }
		[Ordinal(1)]  [RED("objectThatTargets")] public wCHandle<gameObject> ObjectThatTargets { get; set; }

		public OnBeingTarget(CR2WFile cr2w, CVariable parent, string name) : base(cr2w, parent, name) { }
	}
}
