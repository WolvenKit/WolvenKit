using System.IO;
using CP77.CR2W.Reflection;
using FastMember;
using static CP77.CR2W.Types.Enums;

namespace CP77.CR2W.Types
{
	[REDMeta]
	public class vehicleForbiddenAreaState : CVariable
	{
		[Ordinal(0)] [RED("globalNodeIDHash")] public CUInt64 GlobalNodeIDHash { get; set; }
		[Ordinal(1)] [RED("enabled")] public CBool Enabled { get; set; }
		[Ordinal(2)] [RED("dismount")] public CBool Dismount { get; set; }

		public vehicleForbiddenAreaState(CR2WFile cr2w, CVariable parent, string name) : base(cr2w, parent, name) { }
	}
}
