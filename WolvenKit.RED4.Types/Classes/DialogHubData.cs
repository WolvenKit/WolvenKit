using static WolvenKit.RED4.Types.Enums;

namespace WolvenKit.RED4.Types
{
	[REDMeta]
	public partial class DialogHubData : RedBaseClass
	{
		private CBool _isSelected;
		private CInt32 _selectedInd;
		private CBool _hasAboveElements;
		private CBool _hasBelowElements;
		private CInt32 _currentNum;
		private CInt32 _argTotalCountAcrossHubs;

		[Ordinal(0)] 
		[RED("isSelected")] 
		public CBool IsSelected
		{
			get => GetProperty(ref _isSelected);
			set => SetProperty(ref _isSelected, value);
		}

		[Ordinal(1)] 
		[RED("selectedInd")] 
		public CInt32 SelectedInd
		{
			get => GetProperty(ref _selectedInd);
			set => SetProperty(ref _selectedInd, value);
		}

		[Ordinal(2)] 
		[RED("hasAboveElements")] 
		public CBool HasAboveElements
		{
			get => GetProperty(ref _hasAboveElements);
			set => SetProperty(ref _hasAboveElements, value);
		}

		[Ordinal(3)] 
		[RED("hasBelowElements")] 
		public CBool HasBelowElements
		{
			get => GetProperty(ref _hasBelowElements);
			set => SetProperty(ref _hasBelowElements, value);
		}

		[Ordinal(4)] 
		[RED("currentNum")] 
		public CInt32 CurrentNum
		{
			get => GetProperty(ref _currentNum);
			set => SetProperty(ref _currentNum, value);
		}

		[Ordinal(5)] 
		[RED("argTotalCountAcrossHubs")] 
		public CInt32 ArgTotalCountAcrossHubs
		{
			get => GetProperty(ref _argTotalCountAcrossHubs);
			set => SetProperty(ref _argTotalCountAcrossHubs, value);
		}
	}
}
