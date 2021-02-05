using System.IO;
using CP77.CR2W.Reflection;
using FastMember;
using static CP77.CR2W.Types.Enums;

namespace CP77.CR2W.Types
{
	[REDMeta]
	public class gameDismemberedLimbCount : CVariable
	{
		[Ordinal(0)]  [RED("fleshDismemberments")] public CUInt32 FleshDismemberments { get; set; }
		[Ordinal(1)]  [RED("cyberDismemberments")] public CUInt32 CyberDismemberments { get; set; }

		public gameDismemberedLimbCount(CR2WFile cr2w, CVariable parent, string name) : base(cr2w, parent, name) { }
	}
}
