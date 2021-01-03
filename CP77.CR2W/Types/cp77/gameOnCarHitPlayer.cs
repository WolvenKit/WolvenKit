using System.IO;
using WolvenKit.CR2W.Reflection;
using FastMember;
using static WolvenKit.CR2W.Types.Enums;

namespace WolvenKit.CR2W.Types
{
	[REDMeta]
	public class gameOnCarHitPlayer : redEvent
	{
		[Ordinal(0)]  [RED("carId")] public entEntityID CarId { get; set; }
		[Ordinal(1)]  [RED("hitDirection")] public Vector4 HitDirection { get; set; }

		public gameOnCarHitPlayer(CR2WFile cr2w, CVariable parent, string name) : base(cr2w, parent, name) { }
	}
}
