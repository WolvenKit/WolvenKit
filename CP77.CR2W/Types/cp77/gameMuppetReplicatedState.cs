using System.IO;
using CP77.CR2W.Reflection;
using FastMember;
using static CP77.CR2W.Types.Enums;

namespace CP77.CR2W.Types
{
	[REDMeta]
	public class gameMuppetReplicatedState : netIEntityState
	{
		[Ordinal(0)]  [RED("state")] public gameMuppetState State { get; set; }
		[Ordinal(1)]  [RED("initialOrientation")] public EulerAngles InitialOrientation { get; set; }
		[Ordinal(2)]  [RED("initialLocation")] public Vector3 InitialLocation { get; set; }
		[Ordinal(3)]  [RED("health")] public CFloat Health { get; set; }
		[Ordinal(4)]  [RED("armor")] public CFloat Armor { get; set; }

		public gameMuppetReplicatedState(CR2WFile cr2w, CVariable parent, string name) : base(cr2w, parent, name) { }
	}
}
