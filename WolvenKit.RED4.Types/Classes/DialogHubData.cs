using static WolvenKit.RED4.Types.Enums;

namespace WolvenKit.RED4.Types
{
	public partial class DialogHubData : RedBaseClass
	{
		[Ordinal(0)] 
		[RED("isSelected")] 
		public CBool IsSelected
		{
			get => GetPropertyValue<CBool>();
			set => SetPropertyValue<CBool>(value);
		}

		[Ordinal(1)] 
		[RED("selectedInd")] 
		public CInt32 SelectedInd
		{
			get => GetPropertyValue<CInt32>();
			set => SetPropertyValue<CInt32>(value);
		}

		[Ordinal(2)] 
		[RED("hasAboveElements")] 
		public CBool HasAboveElements
		{
			get => GetPropertyValue<CBool>();
			set => SetPropertyValue<CBool>(value);
		}

		[Ordinal(3)] 
		[RED("hasBelowElements")] 
		public CBool HasBelowElements
		{
			get => GetPropertyValue<CBool>();
			set => SetPropertyValue<CBool>(value);
		}

		[Ordinal(4)] 
		[RED("currentNum")] 
		public CInt32 CurrentNum
		{
			get => GetPropertyValue<CInt32>();
			set => SetPropertyValue<CInt32>(value);
		}

		[Ordinal(5)] 
		[RED("argTotalCountAcrossHubs")] 
		public CInt32 ArgTotalCountAcrossHubs
		{
			get => GetPropertyValue<CInt32>();
			set => SetPropertyValue<CInt32>(value);
		}

		public DialogHubData()
		{
			PostConstruct();
		}

		partial void PostConstruct();
	}
}
