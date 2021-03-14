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
			get
			{
				if (_item == null)
				{
					_item = (CEnum<HubVendorMenuItems>) CR2WTypeManager.Create("HubVendorMenuItems", "item", cr2w, this);
				}
				return _item;
			}
			set
			{
				if (_item == value)
				{
					return;
				}
				_item = value;
				PropertySet(this);
			}
		}

		public VendorHubMenuChanged(CR2WFile cr2w, CVariable parent, string name) : base(cr2w, parent, name) { }
	}
}
