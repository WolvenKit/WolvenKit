using System.IO;
using CP77.CR2W.Reflection;
using FastMember;
using static CP77.CR2W.Types.Enums;

namespace CP77.CR2W.Types
{
	[REDMeta]
	public class SetThreatsPersistenceRequest : AIAIEvent
	{
		[Ordinal(0)]  [RED("et")] public wCHandle<entEntity> Et { get; set; }
		[Ordinal(1)]  [RED("isPersistent")] public CBool IsPersistent { get; set; }

		public SetThreatsPersistenceRequest(CR2WFile cr2w, CVariable parent, string name) : base(cr2w, parent, name) { }
	}
}
