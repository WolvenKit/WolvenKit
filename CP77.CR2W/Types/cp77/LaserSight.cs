using System.IO;
using WolvenKit.CR2W.Reflection;
using FastMember;
using static WolvenKit.CR2W.Types.Enums;

namespace WolvenKit.CR2W.Types
{
	[REDMeta]
	public class LaserSight : Attack_Beam
	{
		[Ordinal(0)]  [RED("previousTarget")] public wCHandle<entEntity> PreviousTarget { get; set; }

		public LaserSight(CR2WFile cr2w, CVariable parent, string name) : base(cr2w, parent, name) { }
	}
}
