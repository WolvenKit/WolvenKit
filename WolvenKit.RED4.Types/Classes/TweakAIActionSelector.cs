using static WolvenKit.RED4.Types.Enums;

namespace WolvenKit.RED4.Types
{
	[REDMeta]
	public partial class TweakAIActionSelector : TweakAIActionAbstract
	{
		[Ordinal(27)] 
		[RED("selector")] 
		public TweakDBID Selector
		{
			get => GetPropertyValue<TweakDBID>();
			set => SetPropertyValue<TweakDBID>(value);
		}

		[Ordinal(28)] 
		[RED("selectorRecord")] 
		public CWeakHandle<gamedataAIActionSelector_Record> SelectorRecord
		{
			get => GetPropertyValue<CWeakHandle<gamedataAIActionSelector_Record>>();
			set => SetPropertyValue<CWeakHandle<gamedataAIActionSelector_Record>>(value);
		}

		[Ordinal(29)] 
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
		}
	}
}
