using static WolvenKit.RED4.Types.Enums;

namespace WolvenKit.RED4.Types
{
	public partial class CyberwareTooltipData : ATooltipData
	{
		[Ordinal(0)] 
		[RED("label")] 
		public CString Label
		{
			get => GetPropertyValue<CString>();
			set => SetPropertyValue<CString>(value);
		}

		[Ordinal(1)] 
		[RED("slotData")] 
		public CArray<CHandle<CyberwareSlotTooltipData>> SlotData
		{
			get => GetPropertyValue<CArray<CHandle<CyberwareSlotTooltipData>>>();
			set => SetPropertyValue<CArray<CHandle<CyberwareSlotTooltipData>>>(value);
		}

		public CyberwareTooltipData()
		{
			PostConstruct();
		}

		partial void PostConstruct();
	}
}
