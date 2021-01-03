using System.IO;
using WolvenKit.CR2W.Reflection;
using FastMember;
using static WolvenKit.CR2W.Types.Enums;

namespace WolvenKit.CR2W.Types
{
	[REDMeta]
	public class gameMuppetReplicatedState : netIEntityState
	{
		[Ordinal(0)]  [RED("armor")] public CFloat Armor { get; set; }
		[Ordinal(1)]  [RED("health")] public CFloat Health { get; set; }
		[Ordinal(2)]  [RED("initialLocation")] public Vector3 InitialLocation { get; set; }
		[Ordinal(3)]  [RED("initialOrientation")] public EulerAngles InitialOrientation { get; set; }
		[Ordinal(4)]  [RED("state")] public gameMuppetState State { get; set; }

		public gameMuppetReplicatedState(CR2WFile cr2w, CVariable parent, string name) : base(cr2w, parent, name) { }
	}
}
