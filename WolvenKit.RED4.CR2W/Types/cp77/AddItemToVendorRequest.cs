using WolvenKit.RED4.CR2W.Reflection;
using FastMember;
using static WolvenKit.RED4.CR2W.Types.Enums;

namespace WolvenKit.RED4.CR2W.Types
{
	[REDMeta]
	public class AddItemToVendorRequest : gameScriptableSystemRequest
	{
		private TweakDBID _vendorID;
		private TweakDBID _itemToAddID;
		private CInt32 _quantity;

		[Ordinal(0)] 
		[RED("vendorID")] 
		public TweakDBID VendorID
		{
			get => GetProperty(ref _vendorID);
			set => SetProperty(ref _vendorID, value);
		}

		[Ordinal(1)] 
		[RED("itemToAddID")] 
		public TweakDBID ItemToAddID
		{
			get => GetProperty(ref _itemToAddID);
			set => SetProperty(ref _itemToAddID, value);
		}

		[Ordinal(2)] 
		[RED("quantity")] 
		public CInt32 Quantity
		{
			get => GetProperty(ref _quantity);
			set => SetProperty(ref _quantity, value);
		}

		public AddItemToVendorRequest(IRed4EngineFile cr2w, CVariable parent, string name) : base(cr2w, parent, name) { }
	}
}
