using System.IO;
using WolvenKit.CR2W.Reflection;
using FastMember;
using static WolvenKit.CR2W.Types.Enums;

namespace WolvenKit.CR2W.Types
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
