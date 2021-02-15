using System.IO;
using CP77.CR2W.Reflection;
using FastMember;
using static CP77.CR2W.Types.Enums;

namespace CP77.CR2W.Types
{
	[REDMeta]
	public class gameeventsCloseByEvent : redEvent
	{
		[Ordinal(0)] [RED("position")] public Vector4 Position { get; set; }
		[Ordinal(1)] [RED("forward")] public Vector4 Forward { get; set; }
		[Ordinal(2)] [RED("instigator")] public wCHandle<gameObject> Instigator { get; set; }
		[Ordinal(3)] [RED("attackData")] public CHandle<gamedamageAttackData> AttackData { get; set; }

		public gameeventsCloseByEvent(CR2WFile cr2w, CVariable parent, string name) : base(cr2w, parent, name) { }
	}
}
