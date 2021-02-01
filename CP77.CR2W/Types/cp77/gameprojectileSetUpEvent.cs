using System.IO;
using CP77.CR2W.Reflection;
using FastMember;
using static CP77.CR2W.Types.Enums;

namespace CP77.CR2W.Types
{
	[REDMeta]
	public class gameprojectileSetUpEvent : redEvent
	{
		[Ordinal(0)]  [RED("lerpMultiplier")] public CFloat LerpMultiplier { get; set; }
		[Ordinal(1)]  [RED("owner")] public wCHandle<gameObject> Owner { get; set; }
		[Ordinal(2)]  [RED("trajectoryParams")] public CHandle<gameprojectileTrajectoryParams> TrajectoryParams { get; set; }
		[Ordinal(3)]  [RED("weapon")] public wCHandle<gameObject> Weapon { get; set; }

		public gameprojectileSetUpEvent(CR2WFile cr2w, CVariable parent, string name) : base(cr2w, parent, name) { }
	}
}
