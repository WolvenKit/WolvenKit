using WolvenKit.RED4.CR2W.Reflection;
using FastMember;
using static WolvenKit.RED4.CR2W.Types.Enums;

namespace WolvenKit.RED4.CR2W.Types
{
	[REDMeta]
	public class gameOnCarHitPlayer : redEvent
	{
		[Ordinal(0)] [RED("hitDirection")] public Vector4 HitDirection { get; set; }
		[Ordinal(1)] [RED("carId")] public entEntityID CarId { get; set; }

		public gameOnCarHitPlayer(CR2WFile cr2w, CVariable parent, string name) : base(cr2w, parent, name) { }
	}
}
