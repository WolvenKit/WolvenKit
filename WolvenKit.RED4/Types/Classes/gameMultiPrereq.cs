using static WolvenKit.RED4.Types.Enums;

namespace WolvenKit.RED4.Types
{
	public partial class gameMultiPrereq : gameIPrereq
	{
		[Ordinal(0)] 
		[RED("aggregationType")] 
		public CEnum<gameAggregationType> AggregationType
		{
			get => GetPropertyValue<CEnum<gameAggregationType>>();
			set => SetPropertyValue<CEnum<gameAggregationType>>(value);
		}

		[Ordinal(1)] 
		[RED("nestedPrereqs")] 
		public CArray<CHandle<gameIPrereq>> NestedPrereqs
		{
			get => GetPropertyValue<CArray<CHandle<gameIPrereq>>>();
			set => SetPropertyValue<CArray<CHandle<gameIPrereq>>>(value);
		}

		public gameMultiPrereq()
		{
			NestedPrereqs = new();

			PostConstruct();
		}

		partial void PostConstruct();
	}
}
