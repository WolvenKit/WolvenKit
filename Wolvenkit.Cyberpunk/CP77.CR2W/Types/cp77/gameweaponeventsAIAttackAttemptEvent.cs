using System.IO;
using CP77.CR2W.Reflection;
using FastMember;
using static CP77.CR2W.Types.Enums;

namespace CP77.CR2W.Types
{
	[REDMeta]
	public class gameweaponeventsAIAttackAttemptEvent : redEvent
	{
		[Ordinal(0)]  [RED("continuousMode")] public CEnum<gameEContinuousMode> ContinuousMode { get; set; }
		[Ordinal(1)]  [RED("instigator")] public wCHandle<gameObject> Instigator { get; set; }
		[Ordinal(2)]  [RED("isWindUp")] public CBool IsWindUp { get; set; }
		[Ordinal(3)]  [RED("minimumOpacity")] public CFloat MinimumOpacity { get; set; }
		[Ordinal(4)]  [RED("target")] public wCHandle<gameObject> Target { get; set; }

		public gameweaponeventsAIAttackAttemptEvent(CR2WFile cr2w, CVariable parent, string name) : base(cr2w, parent, name) { }
	}
}
