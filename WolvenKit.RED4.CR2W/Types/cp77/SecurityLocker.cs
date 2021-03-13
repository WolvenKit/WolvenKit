using WolvenKit.RED4.CR2W.Reflection;
using FastMember;
using static WolvenKit.RED4.CR2W.Types.Enums;

namespace WolvenKit.RED4.CR2W.Types
{
	[REDMeta]
	public class SecurityLocker : InteractiveDevice
	{
		[Ordinal(93)] [RED("inventory")] public CHandle<gameInventory> Inventory { get; set; }
		[Ordinal(94)] [RED("cachedEvent")] public CHandle<UseSecurityLocker> CachedEvent { get; set; }

		public SecurityLocker(CR2WFile cr2w, CVariable parent, string name) : base(cr2w, parent, name) { }
	}
}
