using WolvenKit.RED4.CR2W.Reflection;
using FastMember;
using static WolvenKit.RED4.CR2W.Types.Enums;

namespace WolvenKit.RED4.CR2W.Types
{
	[REDMeta]
	public class DispenceItemFromVendor : ActionBool
	{
		private gameItemID _itemID;
		private CInt32 _price;
		private CName _atlasTexture;

		[Ordinal(25)] 
		[RED("itemID")] 
		public gameItemID ItemID
		{
			get => GetProperty(ref _itemID);
			set => SetProperty(ref _itemID, value);
		}

		[Ordinal(26)] 
		[RED("price")] 
		public CInt32 Price
		{
			get => GetProperty(ref _price);
			set => SetProperty(ref _price, value);
		}

		[Ordinal(27)] 
		[RED("atlasTexture")] 
		public CName AtlasTexture
		{
			get => GetProperty(ref _atlasTexture);
			set => SetProperty(ref _atlasTexture, value);
		}

		public DispenceItemFromVendor(CR2WFile cr2w, CVariable parent, string name) : base(cr2w, parent, name) { }
	}
}
