using System.IO;
using WolvenKit.CR2W.Reflection;
using FastMember;
using static WolvenKit.CR2W.Types.Enums;

namespace WolvenKit.CR2W.Types
{
	[REDMeta]
	public class SuppressNPCInSecuritySystem : redEvent
	{
		[Ordinal(0)]  [RED("suppressIncomingEvents")] public CBool SuppressIncomingEvents { get; set; }
		[Ordinal(1)]  [RED("suppressOutgoingEvents")] public CBool SuppressOutgoingEvents { get; set; }

		public SuppressNPCInSecuritySystem(CR2WFile cr2w, CVariable parent, string name) : base(cr2w, parent, name) { }
	}
}
