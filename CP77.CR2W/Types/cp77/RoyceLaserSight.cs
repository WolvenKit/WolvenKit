using System.IO;
using CP77.CR2W.Reflection;
using FastMember;
using static CP77.CR2W.Types.Enums;

namespace CP77.CR2W.Types
{
	[REDMeta]
	public class RoyceLaserSight : Attack_Beam
	{
		[Ordinal(0)]  [RED("previousTarget")] public wCHandle<entEntity> PreviousTarget { get; set; }

		public RoyceLaserSight(CR2WFile cr2w, CVariable parent, string name) : base(cr2w, parent, name) { }
	}
}
