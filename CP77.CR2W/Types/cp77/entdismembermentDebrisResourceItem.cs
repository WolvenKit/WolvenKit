using System.IO;
using CP77.CR2W.Reflection;
using FastMember;
using static CP77.CR2W.Types.Enums;

namespace CP77.CR2W.Types
{
	[REDMeta]
	public class entdismembermentDebrisResourceItem : CVariable
	{
		[Ordinal(0)] [RED("rig")] public rRef<animRig> Rig { get; set; }
		[Ordinal(1)] [RED("mesh")] public rRef<CMesh> Mesh { get; set; }

		public entdismembermentDebrisResourceItem(CR2WFile cr2w, CVariable parent, string name) : base(cr2w, parent, name) { }
	}
}
