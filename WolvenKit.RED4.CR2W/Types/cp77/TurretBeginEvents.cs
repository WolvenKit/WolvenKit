using WolvenKit.RED4.CR2W.Reflection;
using FastMember;
using static WolvenKit.RED4.CR2W.Types.Enums;

namespace WolvenKit.RED4.CR2W.Types
{
	[REDMeta]
	public class TurretBeginEvents : TurretTransition
	{
		[Ordinal(0)] [RED("stateMachineInitData")] public wCHandle<TurretInitData> StateMachineInitData { get; set; }

		public TurretBeginEvents(CR2WFile cr2w, CVariable parent, string name) : base(cr2w, parent, name) { }
	}
}
