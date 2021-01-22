using System.IO;
using CP77.CR2W.Reflection;
using FastMember;
using static CP77.CR2W.Types.Enums;

namespace CP77.CR2W.Types
{
	[REDMeta]
	public class NetworkArea : InteractiveMasterDevice
	{
		[Ordinal(0)]  [RED("area")] public CHandle<gameStaticTriggerAreaComponent> Area { get; set; }

		public NetworkArea(CR2WFile cr2w, CVariable parent, string name) : base(cr2w, parent, name) { }
	}
}
