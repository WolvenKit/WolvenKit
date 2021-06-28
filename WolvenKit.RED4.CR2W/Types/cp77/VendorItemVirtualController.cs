using WolvenKit.RED4.CR2W.Reflection;
using FastMember;
using static WolvenKit.RED4.CR2W.Types.Enums;

namespace WolvenKit.RED4.CR2W.Types
{
	[REDMeta]
	public class VendorItemVirtualController : inkVirtualCompoundItemController
	{
		private CHandle<VendorInventoryItemData> _data;

		[Ordinal(15)] 
		[RED("data")] 
		public CHandle<VendorInventoryItemData> Data
		{
			get => GetProperty(ref _data);
			set => SetProperty(ref _data, value);
		}

		public VendorItemVirtualController(IRed4EngineFile cr2w, CVariable parent, string name) : base(cr2w, parent, name) { }
	}
}
