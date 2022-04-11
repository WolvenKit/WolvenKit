using static WolvenKit.RED4.Types.Enums;

namespace WolvenKit.RED4.Types
{
	public partial class ClueRecordData : RedBaseClass
	{
		[Ordinal(0)] 
		[RED("clueRecord")] 
		public TweakDBID ClueRecord
		{
			get => GetPropertyValue<TweakDBID>();
			set => SetPropertyValue<TweakDBID>(value);
		}

		[Ordinal(1)] 
		[RED("percentage")] 
		public CFloat Percentage
		{
			get => GetPropertyValue<CFloat>();
			set => SetPropertyValue<CFloat>(value);
		}

		[Ordinal(2)] 
		[RED("facts")] 
		public CArray<SFactOperationData> Facts
		{
			get => GetPropertyValue<CArray<SFactOperationData>>();
			set => SetPropertyValue<CArray<SFactOperationData>>(value);
		}

		[Ordinal(3)] 
		[RED("wasInspected")] 
		public CBool WasInspected
		{
			get => GetPropertyValue<CBool>();
			set => SetPropertyValue<CBool>(value);
		}

		public ClueRecordData()
		{
			Facts = new();

			PostConstruct();
		}

		partial void PostConstruct();
	}
}
