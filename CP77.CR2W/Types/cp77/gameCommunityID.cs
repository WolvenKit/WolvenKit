using System.IO;
using CP77.CR2W.Reflection;
using FastMember;
using static CP77.CR2W.Types.Enums;

namespace CP77.CR2W.Types
{
	[REDMeta]
	public class gameCommunityID : CVariable
	{
		[Ordinal(0)] [RED("entityId")] public entEntityID EntityId { get; set; }

		public gameCommunityID(CR2WFile cr2w, CVariable parent, string name) : base(cr2w, parent, name) { }
	}
}
