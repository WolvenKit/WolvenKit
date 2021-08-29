using static WolvenKit.RED4.Types.Enums;

namespace WolvenKit.RED4.Types
{
	[REDMeta]
	public partial class PerkHoverOverEvent : redEvent
	{
		private CWeakHandle<inkWidget> _widget;
		private CInt32 _perkIndex;
		private CHandle<BasePerkDisplayData> _perkData;

		[Ordinal(0)] 
		[RED("widget")] 
		public CWeakHandle<inkWidget> Widget
		{
			get => GetProperty(ref _widget);
			set => SetProperty(ref _widget, value);
		}

		[Ordinal(1)] 
		[RED("perkIndex")] 
		public CInt32 PerkIndex
		{
			get => GetProperty(ref _perkIndex);
			set => SetProperty(ref _perkIndex, value);
		}

		[Ordinal(2)] 
		[RED("perkData")] 
		public CHandle<BasePerkDisplayData> PerkData
		{
			get => GetProperty(ref _perkData);
			set => SetProperty(ref _perkData, value);
		}
	}
}
