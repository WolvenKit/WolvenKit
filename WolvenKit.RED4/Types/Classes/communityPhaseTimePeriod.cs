using static WolvenKit.RED4.Types.Enums;

namespace WolvenKit.RED4.Types
{
	public partial class communityPhaseTimePeriod : communityTimePeriod
	{
		[Ordinal(1)] 
		[RED("quantity")] 
		public CUInt16 Quantity
		{
			get => GetPropertyValue<CUInt16>();
			set => SetPropertyValue<CUInt16>(value);
		}

		[Ordinal(2)] 
		[RED("markings")] 
		public CArray<CName> Markings
		{
			get => GetPropertyValue<CArray<CName>>();
			set => SetPropertyValue<CArray<CName>>(value);
		}

		[Ordinal(3)] 
		[RED("spotNodeRefs")] 
		public CArray<NodeRef> SpotNodeRefs
		{
			get => GetPropertyValue<CArray<NodeRef>>();
			set => SetPropertyValue<CArray<NodeRef>>(value);
		}

		[Ordinal(4)] 
		[RED("categories")] 
		public CArray<gameSpotSequenceCategory> Categories
		{
			get => GetPropertyValue<CArray<gameSpotSequenceCategory>>();
			set => SetPropertyValue<CArray<gameSpotSequenceCategory>>(value);
		}

		[Ordinal(5)] 
		[RED("isSequence")] 
		public CBool IsSequence
		{
			get => GetPropertyValue<CBool>();
			set => SetPropertyValue<CBool>(value);
		}

		public communityPhaseTimePeriod()
		{
			Quantity = 1;
			Markings = new();
			SpotNodeRefs = new();
			Categories = new();

			PostConstruct();
		}

		partial void PostConstruct();
	}
}
