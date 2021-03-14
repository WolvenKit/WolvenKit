using WolvenKit.RED4.CR2W.Reflection;
using FastMember;
using static WolvenKit.RED4.CR2W.Types.Enums;

namespace WolvenKit.RED4.CR2W.Types
{
	[REDMeta]
	public class VendorHubMenuChanged : redEvent
	{
		[Ordinal(0)] [RED("item")] public CEnum<HubVendorMenuItems> Item { get; set; }

		public VendorHubMenuChanged(CR2WFile cr2w, CVariable parent, string name) : base(cr2w, parent, name) { }
	}
}
