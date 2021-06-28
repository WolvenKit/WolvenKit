using WolvenKit.RED4.CR2W.Reflection;
using FastMember;
using static WolvenKit.RED4.CR2W.Types.Enums;

namespace WolvenKit.RED4.CR2W.Types
{
	[REDMeta]
	public class VendorHubMenuChanged : redEvent
	{
		private CEnum<HubVendorMenuItems> _item;

		[Ordinal(0)] 
		[RED("item")] 
		public CEnum<HubVendorMenuItems> Item
		{
			get => GetProperty(ref _item);
			set => SetProperty(ref _item, value);
		}

		public VendorHubMenuChanged(IRed4EngineFile cr2w, CVariable parent, string name) : base(cr2w, parent, name) { }
	}
}
