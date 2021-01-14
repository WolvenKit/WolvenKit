using System.IO;
using CP77.CR2W.Reflection;
using FastMember;
using static CP77.CR2W.Types.Enums;

namespace CP77.CR2W.Types
{
	[REDMeta]
	public class SecurityLocker : InteractiveDevice
	{
		[Ordinal(0)]  [RED("cachedEvent")] public CHandle<UseSecurityLocker> CachedEvent { get; set; }
		[Ordinal(1)]  [RED("inventory")] public CHandle<gameInventory> Inventory { get; set; }

		public SecurityLocker(CR2WFile cr2w, CVariable parent, string name) : base(cr2w, parent, name) { }
	}
}
