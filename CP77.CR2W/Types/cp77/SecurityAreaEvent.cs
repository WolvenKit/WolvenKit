using System.IO;
using WolvenKit.CR2W.Reflection;
using FastMember;
using static WolvenKit.CR2W.Types.Enums;

namespace WolvenKit.CR2W.Types
{
	[REDMeta]
	public class SecurityAreaEvent : ActionBool
	{
		[Ordinal(0)]  [RED("securityAreaData")] public SecurityAreaData SecurityAreaData { get; set; }
		[Ordinal(1)]  [RED("whoBreached")] public wCHandle<gameObject> WhoBreached { get; set; }

		public SecurityAreaEvent(CR2WFile cr2w, CVariable parent, string name) : base(cr2w, parent, name) { }
	}
}
