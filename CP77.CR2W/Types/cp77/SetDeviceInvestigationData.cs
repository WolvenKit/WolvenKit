using System.IO;
using CP77.CR2W.Reflection;
using FastMember;
using static CP77.CR2W.Types.Enums;

namespace CP77.CR2W.Types
{
	[REDMeta]
	public class SetDeviceInvestigationData : AIbehaviortaskScript
	{
		[Ordinal(0)] [RED("ownerPuppet")] public wCHandle<ScriptedPuppet> OwnerPuppet { get; set; }
		[Ordinal(1)] [RED("listener")] public wCHandle<gameObject> Listener { get; set; }

		public SetDeviceInvestigationData(CR2WFile cr2w, CVariable parent, string name) : base(cr2w, parent, name) { }
	}
}
