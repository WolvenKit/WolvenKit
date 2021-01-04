using System.IO;
using CP77.CR2W.Reflection;
using FastMember;
using static CP77.CR2W.Types.Enums;

namespace CP77.CR2W.Types
{
	[REDMeta]
	public class gameuiInputHintInitializedEvent : redEvent
	{
		[Ordinal(0)]  [RED("targetHintContainer")] public CName TargetHintContainer { get; set; }

		public gameuiInputHintInitializedEvent(CR2WFile cr2w, CVariable parent, string name) : base(cr2w, parent, name) { }
	}
}
