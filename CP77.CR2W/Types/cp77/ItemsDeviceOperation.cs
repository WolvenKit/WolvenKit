using System.IO;
using CP77.CR2W.Reflection;
using FastMember;
using static CP77.CR2W.Types.Enums;

namespace CP77.CR2W.Types
{
	[REDMeta]
	public class ItemsDeviceOperation : DeviceOperationBase
	{
		[Ordinal(5)]  [RED("items")] public CArray<SInventoryOperationData> Items { get; set; }

		public ItemsDeviceOperation(CR2WFile cr2w, CVariable parent, string name) : base(cr2w, parent, name) { }
	}
}
