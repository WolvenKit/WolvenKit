using CP77.CR2W.Reflection;
using FastMember;
using static CP77.CR2W.Types.Enums;

namespace CP77.CR2W.Types
{
	[REDMeta]
	public class TurretRipOffEvents : TurretTransition
	{
		[Ordinal(0)] [RED("stateMachineInitData")] public wCHandle<TurretInitData> StateMachineInitData { get; set; }

		public TurretRipOffEvents(CR2WFile cr2w, CVariable parent, string name) : base(cr2w, parent, name) { }
	}
}
