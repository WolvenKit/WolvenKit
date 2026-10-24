using static WolvenKit.RED4.Types.Enums;

namespace WolvenKit.RED4.Types
{
	public partial class CyberwareCustomizationPersistentData : RedBaseClass
	{
		[Ordinal(0)] 
		[RED("enabled")] 
		public CBool Enabled
		{
			get => GetPropertyValue<CBool>();
			set => SetPropertyValue<CBool>(value);
		}

		[Ordinal(1)] 
		[RED("customizationItemID")] 
		public gameItemID CustomizationItemID
		{
			get => GetPropertyValue<gameItemID>();
			set => SetPropertyValue<gameItemID>(value);
		}

		[Ordinal(2)] 
		[RED("switcherName")] 
		public CName SwitcherName
		{
			get => GetPropertyValue<CName>();
			set => SetPropertyValue<CName>(value);
		}

		[Ordinal(3)] 
		[RED("switcherIndex")] 
		public CUInt32 SwitcherIndex
		{
			get => GetPropertyValue<CUInt32>();
			set => SetPropertyValue<CUInt32>(value);
		}

		[Ordinal(4)] 
		[RED("brandDataID")] 
		public TweakDBID BrandDataID
		{
			get => GetPropertyValue<TweakDBID>();
			set => SetPropertyValue<TweakDBID>(value);
		}

		[Ordinal(5)] 
		[RED("primaryColorIndex")] 
		public CUInt8 PrimaryColorIndex
		{
			get => GetPropertyValue<CUInt8>();
			set => SetPropertyValue<CUInt8>(value);
		}

		[Ordinal(6)] 
		[RED("secondaryColorIndex")] 
		public CUInt8 SecondaryColorIndex
		{
			get => GetPropertyValue<CUInt8>();
			set => SetPropertyValue<CUInt8>(value);
		}

		[Ordinal(7)] 
		[RED("hasMaxTacApperanceEquipped")] 
		public CBool HasMaxTacApperanceEquipped
		{
			get => GetPropertyValue<CBool>();
			set => SetPropertyValue<CBool>(value);
		}

		public CyberwareCustomizationPersistentData()
		{
			CustomizationItemID = new gameItemID();

			PostConstruct();
		}

		partial void PostConstruct();
	}
}
