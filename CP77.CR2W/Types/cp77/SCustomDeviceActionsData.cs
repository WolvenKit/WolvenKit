using System.IO;
using CP77.CR2W.Reflection;
using FastMember;
using static CP77.CR2W.Types.Enums;

namespace CP77.CR2W.Types
{
	[REDMeta]
	public class SCustomDeviceActionsData : CVariable
	{
		[Ordinal(0)] [RED("actions")] public CArray<SDeviceActionCustomData> Actions { get; set; }

		public SCustomDeviceActionsData(CR2WFile cr2w, CVariable parent, string name) : base(cr2w, parent, name) { }
	}
}
