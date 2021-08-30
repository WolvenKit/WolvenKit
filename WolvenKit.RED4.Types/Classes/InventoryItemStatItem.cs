using static WolvenKit.RED4.Types.Enums;

namespace WolvenKit.RED4.Types
{
	[REDMeta]
	public partial class InventoryItemStatItem : inkWidgetLogicController
	{
		private inkTextWidgetReference _labelText;
		private inkTextWidgetReference _valueText;
		private inkWidgetReference _differenceBarRef;
		private inkWidgetReference _diffrenceArrowIndicatorRef;
		private CWeakHandle<inkWidget> _root;
		private CWeakHandle<StatisticDifferenceBarController> _differenceBar;
		private CName _negativeState;
		private CName _positiveState;

		[Ordinal(1)] 
		[RED("labelText")] 
		public inkTextWidgetReference LabelText
		{
			get => GetProperty(ref _labelText);
			set => SetProperty(ref _labelText, value);
		}

		[Ordinal(2)] 
		[RED("valueText")] 
		public inkTextWidgetReference ValueText
		{
			get => GetProperty(ref _valueText);
			set => SetProperty(ref _valueText, value);
		}

		[Ordinal(3)] 
		[RED("differenceBarRef")] 
		public inkWidgetReference DifferenceBarRef
		{
			get => GetProperty(ref _differenceBarRef);
			set => SetProperty(ref _differenceBarRef, value);
		}

		[Ordinal(4)] 
		[RED("diffrenceArrowIndicatorRef")] 
		public inkWidgetReference DiffrenceArrowIndicatorRef
		{
			get => GetProperty(ref _diffrenceArrowIndicatorRef);
			set => SetProperty(ref _diffrenceArrowIndicatorRef, value);
		}

		[Ordinal(5)] 
		[RED("root")] 
		public CWeakHandle<inkWidget> Root
		{
			get => GetProperty(ref _root);
			set => SetProperty(ref _root, value);
		}

		[Ordinal(6)] 
		[RED("differenceBar")] 
		public CWeakHandle<StatisticDifferenceBarController> DifferenceBar
		{
			get => GetProperty(ref _differenceBar);
			set => SetProperty(ref _differenceBar, value);
		}

		[Ordinal(7)] 
		[RED("negativeState")] 
		public CName NegativeState
		{
			get => GetProperty(ref _negativeState);
			set => SetProperty(ref _negativeState, value);
		}

		[Ordinal(8)] 
		[RED("positiveState")] 
		public CName PositiveState
		{
			get => GetProperty(ref _positiveState);
			set => SetProperty(ref _positiveState, value);
		}

		public InventoryItemStatItem()
		{
			_negativeState = "worse";
			_positiveState = "better";
		}
	}
}
