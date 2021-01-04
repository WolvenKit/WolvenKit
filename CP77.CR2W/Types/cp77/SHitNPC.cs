using System.IO;
using CP77.CR2W.Reflection;
using FastMember;
using static CP77.CR2W.Types.Enums;

namespace CP77.CR2W.Types
{
	[REDMeta]
	public class SHitNPC : CVariable
	{
		[Ordinal(0)]  [RED("calls")] public CInt32 Calls { get; set; }
		[Ordinal(1)]  [RED("entityID")] public entEntityID EntityID { get; set; }

		public SHitNPC(CR2WFile cr2w, CVariable parent, string name) : base(cr2w, parent, name) { }
	}
}
