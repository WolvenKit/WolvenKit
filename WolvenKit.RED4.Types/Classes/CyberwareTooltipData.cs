using static WolvenKit.RED4.Types.Enums;

namespace WolvenKit.RED4.Types
{
	[REDMeta]
	public partial class CyberwareTooltipData : ATooltipData
	{
		private CString _label;
		private CArray<CHandle<CyberwareSlotTooltipData>> _slotData;

		[Ordinal(0)] 
		[RED("label")] 
		public CString Label
		{
			get => GetProperty(ref _label);
			set => SetProperty(ref _label, value);
		}

		[Ordinal(1)] 
		[RED("slotData")] 
		public CArray<CHandle<CyberwareSlotTooltipData>> SlotData
		{
			get => GetProperty(ref _slotData);
			set => SetProperty(ref _slotData, value);
		}
	}
}
