using static WolvenKit.RED4.Types.Enums;

namespace WolvenKit.RED4.Types
{
	[REDMeta]
	public partial class MinimalItemTooltipModAttachmentData : MinimalItemTooltipModData
	{
		private CBool _isEmpty;
		private CString _slotName;
		private CName _qualityName;
		private CInt32 _abilitiesSize;
		private CArray<gameInventoryItemAbility> _abilities;

		[Ordinal(0)] 
		[RED("isEmpty")] 
		public CBool IsEmpty
		{
			get => GetProperty(ref _isEmpty);
			set => SetProperty(ref _isEmpty, value);
		}

		[Ordinal(1)] 
		[RED("slotName")] 
		public CString SlotName
		{
			get => GetProperty(ref _slotName);
			set => SetProperty(ref _slotName, value);
		}

		[Ordinal(2)] 
		[RED("qualityName")] 
		public CName QualityName
		{
			get => GetProperty(ref _qualityName);
			set => SetProperty(ref _qualityName, value);
		}

		[Ordinal(3)] 
		[RED("abilitiesSize")] 
		public CInt32 AbilitiesSize
		{
			get => GetProperty(ref _abilitiesSize);
			set => SetProperty(ref _abilitiesSize, value);
		}

		[Ordinal(4)] 
		[RED("abilities")] 
		public CArray<gameInventoryItemAbility> Abilities
		{
			get => GetProperty(ref _abilities);
			set => SetProperty(ref _abilities, value);
		}
	}
}
