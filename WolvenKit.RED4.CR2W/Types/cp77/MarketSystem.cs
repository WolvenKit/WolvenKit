using WolvenKit.RED4.CR2W.Reflection;
using FastMember;
using static WolvenKit.RED4.CR2W.Types.Enums;

namespace WolvenKit.RED4.CR2W.Types
{
	[REDMeta]
	public class MarketSystem : gameIMarketSystem
	{
		private CArray<CHandle<Vendor>> _vendors;
		private CArray<CHandle<Vendor>> _vendingMachinesVendors;

		[Ordinal(0)] 
		[RED("vendors")] 
		public CArray<CHandle<Vendor>> Vendors
		{
			get
			{
				if (_vendors == null)
				{
					_vendors = (CArray<CHandle<Vendor>>) CR2WTypeManager.Create("array:handle:Vendor", "vendors", cr2w, this);
				}
				return _vendors;
			}
			set
			{
				if (_vendors == value)
				{
					return;
				}
				_vendors = value;
				PropertySet(this);
			}
		}

		[Ordinal(1)] 
		[RED("vendingMachinesVendors")] 
		public CArray<CHandle<Vendor>> VendingMachinesVendors
		{
			get
			{
				if (_vendingMachinesVendors == null)
				{
					_vendingMachinesVendors = (CArray<CHandle<Vendor>>) CR2WTypeManager.Create("array:handle:Vendor", "vendingMachinesVendors", cr2w, this);
				}
				return _vendingMachinesVendors;
			}
			set
			{
				if (_vendingMachinesVendors == value)
				{
					return;
				}
				_vendingMachinesVendors = value;
				PropertySet(this);
			}
		}

		public MarketSystem(CR2WFile cr2w, CVariable parent, string name) : base(cr2w, parent, name) { }
	}
}
