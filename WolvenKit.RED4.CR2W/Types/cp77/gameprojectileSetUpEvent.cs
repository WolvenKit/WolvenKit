using WolvenKit.RED4.CR2W.Reflection;
using FastMember;
using static WolvenKit.RED4.CR2W.Types.Enums;

namespace WolvenKit.RED4.CR2W.Types
{
	[REDMeta]
	public class gameprojectileSetUpEvent : redEvent
	{
		[Ordinal(0)] [RED("owner")] public wCHandle<gameObject> Owner { get; set; }
		[Ordinal(1)] [RED("weapon")] public wCHandle<gameObject> Weapon { get; set; }
		[Ordinal(2)] [RED("trajectoryParams")] public CHandle<gameprojectileTrajectoryParams> TrajectoryParams { get; set; }
		[Ordinal(3)] [RED("lerpMultiplier")] public CFloat LerpMultiplier { get; set; }

		public gameprojectileSetUpEvent(CR2WFile cr2w, CVariable parent, string name) : base(cr2w, parent, name) { }
	}
}
