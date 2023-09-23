using static WolvenKit.RED4.Types.Enums;

namespace WolvenKit.RED4.Types
{
	public partial class MinimalItemTooltipModAttachmentData : MinimalItemTooltipModData
	{
		[Ordinal(0)] 
		[RED("isEmpty")] 
		public CBool IsEmpty
		{
			get => GetPropertyValue<CBool>();
			set => SetPropertyValue<CBool>(value);
		}

		[Ordinal(1)] 
		[RED("slotName")] 
		public CString SlotName
		{
			get => GetPropertyValue<CString>();
			set => SetPropertyValue<CString>(value);
		}

		[Ordinal(2)] 
		[RED("qualityName")] 
		public CName QualityName
		{
			get => GetPropertyValue<CName>();
			set => SetPropertyValue<CName>(value);
		}

		[Ordinal(3)] 
		[RED("abilitiesSize")] 
		public CInt32 AbilitiesSize
		{
			get => GetPropertyValue<CInt32>();
			set => SetPropertyValue<CInt32>(value);
		}

		[Ordinal(4)] 
		[RED("abilities")] 
		public CArray<gameInventoryItemAbility> Abilities
		{
			get => GetPropertyValue<CArray<gameInventoryItemAbility>>();
			set => SetPropertyValue<CArray<gameInventoryItemAbility>>(value);
		}

		public MinimalItemTooltipModAttachmentData()
		{
			PostConstruct();
		}

		partial void PostConstruct();
	}
}
