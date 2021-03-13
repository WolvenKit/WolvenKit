using WolvenKit.RED4.CR2W.Reflection;
using FastMember;
using static WolvenKit.RED4.CR2W.Types.Enums;

namespace WolvenKit.RED4.CR2W.Types
{
	[REDMeta]
	public class VendingTerminal : InteractiveDevice
	{
		[Ordinal(93)] [RED("position")] public Vector4 Position { get; set; }
		[Ordinal(94)] [RED("canMeshComponent")] public CHandle<entMeshComponent> CanMeshComponent { get; set; }
		[Ordinal(95)] [RED("vendingBlacklist")] public CArray<CEnum<EVendorMode>> VendingBlacklist { get; set; }

		public VendingTerminal(CR2WFile cr2w, CVariable parent, string name) : base(cr2w, parent, name) { }
	}
}
