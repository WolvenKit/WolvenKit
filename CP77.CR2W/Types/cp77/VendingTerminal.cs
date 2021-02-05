using System.IO;
using CP77.CR2W.Reflection;
using FastMember;
using static CP77.CR2W.Types.Enums;

namespace CP77.CR2W.Types
{
	[REDMeta]
	public class VendingTerminal : InteractiveDevice
	{
		[Ordinal(84)]  [RED("position")] public Vector4 Position { get; set; }
		[Ordinal(85)]  [RED("canMeshComponent")] public CHandle<entMeshComponent> CanMeshComponent { get; set; }
		[Ordinal(86)]  [RED("vendingBlacklist")] public CArray<CEnum<EVendorMode>> VendingBlacklist { get; set; }

		public VendingTerminal(CR2WFile cr2w, CVariable parent, string name) : base(cr2w, parent, name) { }
	}
}
