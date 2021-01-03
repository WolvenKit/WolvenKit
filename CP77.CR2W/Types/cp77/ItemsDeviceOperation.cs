using System.IO;
using WolvenKit.CR2W.Reflection;
using FastMember;
using static WolvenKit.CR2W.Types.Enums;

namespace WolvenKit.CR2W.Types
{
	[REDMeta]
	public class ItemsDeviceOperation : DeviceOperationBase
	{
		[Ordinal(0)]  [RED("items")] public CArray<SInventoryOperationData> Items { get; set; }

		public ItemsDeviceOperation(CR2WFile cr2w, CVariable parent, string name) : base(cr2w, parent, name) { }
	}
}
