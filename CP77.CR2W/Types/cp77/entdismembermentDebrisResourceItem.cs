using System.IO;
using WolvenKit.CR2W.Reflection;
using FastMember;
using static WolvenKit.CR2W.Types.Enums;

namespace WolvenKit.CR2W.Types
{
	[REDMeta]
	public class entdismembermentDebrisResourceItem : CVariable
	{
		[Ordinal(0)]  [RED("mesh")] public rRef<CMesh> Mesh { get; set; }
		[Ordinal(1)]  [RED("rig")] public rRef<animRig> Rig { get; set; }

		public entdismembermentDebrisResourceItem(CR2WFile cr2w, CVariable parent, string name) : base(cr2w, parent, name) { }
	}
}
