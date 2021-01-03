using System.IO;
using WolvenKit.CR2W.Reflection;
using FastMember;
using static WolvenKit.CR2W.Types.Enums;

namespace WolvenKit.CR2W.Types
{
	[REDMeta]
	public class IgnoreListEvent : redEvent
	{
		[Ordinal(0)]  [RED("bodyID")] public entEntityID BodyID { get; set; }
		[Ordinal(1)]  [RED("removeEvent")] public CBool RemoveEvent { get; set; }

		public IgnoreListEvent(CR2WFile cr2w, CVariable parent, string name) : base(cr2w, parent, name) { }
	}
}
