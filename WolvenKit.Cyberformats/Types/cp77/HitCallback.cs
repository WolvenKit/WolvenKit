using CP77.CR2W.Reflection;
using FastMember;
using static CP77.CR2W.Types.Enums;

namespace CP77.CR2W.Types
{
	[REDMeta]
	public class HitCallback : gameScriptedDamageSystemListener
	{
		[Ordinal(0)] [RED("state")] public wCHandle<GenericHitPrereqState> State { get; set; }

		public HitCallback(CR2WFile cr2w, CVariable parent, string name) : base(cr2w, parent, name) { }
	}
}
