using static WolvenKit.RED4.Types.Enums;

namespace WolvenKit.RED4.Types
{
	[REDMeta]
	public partial class CyberwareTooltip : AGenericTooltipController
	{
		private inkCompoundWidgetReference _slotList;
		private inkTextWidgetReference _label;
		private CHandle<CyberwareTooltipData> _data;

		[Ordinal(2)] 
		[RED("slotList")] 
		public inkCompoundWidgetReference SlotList
		{
			get => GetProperty(ref _slotList);
			set => SetProperty(ref _slotList, value);
		}

		[Ordinal(3)] 
		[RED("label")] 
		public inkTextWidgetReference Label
		{
			get => GetProperty(ref _label);
			set => SetProperty(ref _label, value);
		}

		[Ordinal(4)] 
		[RED("data")] 
		public CHandle<CyberwareTooltipData> Data
		{
			get => GetProperty(ref _data);
			set => SetProperty(ref _data, value);
		}
	}
}
