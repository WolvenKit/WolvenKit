using System.IO;
using CP77.CR2W.Reflection;
using FastMember;
using static CP77.CR2W.Types.Enums;

namespace CP77.CR2W.Types
{
	[REDMeta]
	public class VendingTerminal : InteractiveDevice
	{
		[Ordinal(0)]  [RED("canMeshComponent")] public CHandle<entMeshComponent> CanMeshComponent { get; set; }
		[Ordinal(1)]  [RED("position")] public Vector4 Position { get; set; }
		[Ordinal(2)]  [RED("vendingBlacklist")] public CArray<CEnum<EVendorMode>> VendingBlacklist { get; set; }

		public VendingTerminal(CR2WFile cr2w, CVariable parent, string name) : base(cr2w, parent, name) { }
	}
}
