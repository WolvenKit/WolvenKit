using System.IO;
using CP77.CR2W.Reflection;
using FastMember;
using static CP77.CR2W.Types.Enums;

namespace CP77.CR2W.Types
{
	[REDMeta]
	public class SGenericDevicePersistentData : CVariable
	{
		[Ordinal(0)]  [RED("customActions")] public SCustomDeviceActionsData CustomActions { get; set; }
		[Ordinal(1)]  [RED("genericActions")] public SGenericDeviceActionsData GenericActions { get; set; }

		public SGenericDevicePersistentData(CR2WFile cr2w, CVariable parent, string name) : base(cr2w, parent, name) { }
	}
}
