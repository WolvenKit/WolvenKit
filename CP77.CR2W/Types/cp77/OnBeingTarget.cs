using System.IO;
using WolvenKit.CR2W.Reflection;
using FastMember;
using static WolvenKit.CR2W.Types.Enums;

namespace WolvenKit.CR2W.Types
{
	[REDMeta]
	public class OnBeingTarget : redEvent
	{
		[Ordinal(0)]  [RED("noLongerTarget")] public CBool NoLongerTarget { get; set; }
		[Ordinal(1)]  [RED("objectThatTargets")] public wCHandle<gameObject> ObjectThatTargets { get; set; }

		public OnBeingTarget(CR2WFile cr2w, CVariable parent, string name) : base(cr2w, parent, name) { }
	}
}
