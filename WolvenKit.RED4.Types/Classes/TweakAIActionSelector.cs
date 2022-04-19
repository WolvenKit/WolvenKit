using static WolvenKit.RED4.Types.Enums;

namespace WolvenKit.RED4.Types
{
	public partial class TweakAIActionSelector : TweakAIActionAbstract
	{
		[Ordinal(36)] 
		[RED("selector")] 
		public TweakDBID Selector
		{
			get => GetPropertyValue<TweakDBID>();
			set => SetPropertyValue<TweakDBID>(value);
		}

		[Ordinal(37)] 
		[RED("selectorRecord")] 
		public CWeakHandle<gamedataAIActionSelector_Record> SelectorRecord
		{
			get => GetPropertyValue<CWeakHandle<gamedataAIActionSelector_Record>>();
			set => SetPropertyValue<CWeakHandle<gamedataAIActionSelector_Record>>(value);
		}

		[Ordinal(38)] 
		[RED("nodeIterator")] 
		public CInt32 NodeIterator
		{
			get => GetPropertyValue<CInt32>();
			set => SetPropertyValue<CInt32>(value);
		}

		public TweakAIActionSelector()
		{
			LookatEvents = new();
			GeneralSubActionsResults = new(8);
			PhaseSubActionsResults = new(8);

			PostConstruct();
		}

		partial void PostConstruct();
	}
}
