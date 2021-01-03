using System.IO;
using WolvenKit.CR2W.Reflection;
using FastMember;
using static WolvenKit.CR2W.Types.Enums;

namespace WolvenKit.CR2W.Types
{
	[REDMeta]
	public class ForcedDeathEvent : redEvent
	{
		[Ordinal(0)]  [RED("forceRagdoll")] public CBool ForceRagdoll { get; set; }
		[Ordinal(1)]  [RED("hitBodyPart")] public CInt32 HitBodyPart { get; set; }
		[Ordinal(2)]  [RED("hitDirection")] public CInt32 HitDirection { get; set; }
		[Ordinal(3)]  [RED("hitIntensity")] public CInt32 HitIntensity { get; set; }
		[Ordinal(4)]  [RED("hitNpcMovementDirection")] public CInt32 HitNpcMovementDirection { get; set; }
		[Ordinal(5)]  [RED("hitNpcMovementSpeed")] public CInt32 HitNpcMovementSpeed { get; set; }
		[Ordinal(6)]  [RED("hitSource")] public CInt32 HitSource { get; set; }
		[Ordinal(7)]  [RED("hitType")] public CInt32 HitType { get; set; }

		public ForcedDeathEvent(CR2WFile cr2w, CVariable parent, string name) : base(cr2w, parent, name) { }
	}
}
