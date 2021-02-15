using System.IO;
using CP77.CR2W.Reflection;
using FastMember;
using static CP77.CR2W.Types.Enums;

namespace CP77.CR2W.Types
{
	[REDMeta]
	public class VehicleTransition : DefaultTransition
	{
		[Ordinal(0)] [RED("stateMachineInitData")] public wCHandle<VehicleTransitionInitData> StateMachineInitData { get; set; }

		public VehicleTransition(CR2WFile cr2w, CVariable parent, string name) : base(cr2w, parent, name) { }
	}
}
