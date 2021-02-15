using System.IO;
using CP77.CR2W.Reflection;
using FastMember;
using static CP77.CR2W.Types.Enums;

namespace CP77.CR2W.Types
{
	[REDMeta]
	public class entContextualLookAtRemoveEvent : entLookAtRemoveEvent
	{
		[Ordinal(3)] [RED("contextName")] public CName ContextName { get; set; }

		public entContextualLookAtRemoveEvent(CR2WFile cr2w, CVariable parent, string name) : base(cr2w, parent, name) { }
	}
}
