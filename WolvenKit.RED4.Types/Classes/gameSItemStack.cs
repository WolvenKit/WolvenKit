using static WolvenKit.RED4.Types.Enums;

namespace WolvenKit.RED4.Types
{
	[REDMeta]
	public partial class gameSItemStack : RedBaseClass
	{
		[Ordinal(0)] 
		[RED("itemID")] 
		public gameItemID ItemID
		{
			get => GetPropertyValue<gameItemID>();
			set => SetPropertyValue<gameItemID>(value);
		}

		[Ordinal(1)] 
		[RED("quantity")] 
		public CInt32 Quantity
		{
			get => GetPropertyValue<CInt32>();
			set => SetPropertyValue<CInt32>(value);
		}

		[Ordinal(2)] 
		[RED("powerLevel")] 
		public CInt32 PowerLevel
		{
			get => GetPropertyValue<CInt32>();
			set => SetPropertyValue<CInt32>(value);
		}

		[Ordinal(3)] 
		[RED("vendorItemID")] 
		public TweakDBID VendorItemID
		{
			get => GetPropertyValue<TweakDBID>();
			set => SetPropertyValue<TweakDBID>(value);
		}

		[Ordinal(4)] 
		[RED("isAvailable")] 
		public CBool IsAvailable
		{
			get => GetPropertyValue<CBool>();
			set => SetPropertyValue<CBool>(value);
		}

		[Ordinal(5)] 
		[RED("requirement")] 
		public gameSItemStackRequirementData Requirement
		{
			get => GetPropertyValue<gameSItemStackRequirementData>();
			set => SetPropertyValue<gameSItemStackRequirementData>(value);
		}

		public gameSItemStack()
		{
			ItemID = new();
			Quantity = 1;
			IsAvailable = true;
			Requirement = new() { StatType = Enums.gamedataStatType.Invalid };
		}
	}
}
