using System.IO;
using WolvenKit.CR2W.Reflection;
using FastMember;
using static WolvenKit.CR2W.Types.Enums;

namespace WolvenKit.CR2W.Types
{
	[REDMeta]
	public class SecurityLocker : InteractiveDevice
	{
		[Ordinal(0)]  [RED("cachedEvent")] public CHandle<UseSecurityLocker> CachedEvent { get; set; }
		[Ordinal(1)]  [RED("inventory")] public CHandle<gameInventory> Inventory { get; set; }

		public SecurityLocker(CR2WFile cr2w, CVariable parent, string name) : base(cr2w, parent, name) { }
	}
}
