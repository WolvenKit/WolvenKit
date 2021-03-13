using WolvenKit.RED4.CR2W.Reflection;
using FastMember;
using static WolvenKit.RED4.CR2W.Types.Enums;

namespace WolvenKit.RED4.CR2W.Types
{
	[REDMeta]
	public class entdismembermentDebrisResourceItem : CVariable
	{
		[Ordinal(0)] [RED("rig")] public rRef<animRig> Rig { get; set; }
		[Ordinal(1)] [RED("mesh")] public rRef<CMesh> Mesh { get; set; }

		public entdismembermentDebrisResourceItem(CR2WFile cr2w, CVariable parent, string name) : base(cr2w, parent, name) { }
	}
}
