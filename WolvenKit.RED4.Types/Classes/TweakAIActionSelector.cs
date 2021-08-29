using static WolvenKit.RED4.Types.Enums;

namespace WolvenKit.RED4.Types
{
	[REDMeta]
	public partial class TweakAIActionSelector : TweakAIActionAbstract
	{
		private TweakDBID _selector;
		private CWeakHandle<gamedataAIActionSelector_Record> _selectorRecord;
		private CInt32 _nodeIterator;

		[Ordinal(27)] 
		[RED("selector")] 
		public TweakDBID Selector
		{
			get => GetProperty(ref _selector);
			set => SetProperty(ref _selector, value);
		}

		[Ordinal(28)] 
		[RED("selectorRecord")] 
		public CWeakHandle<gamedataAIActionSelector_Record> SelectorRecord
		{
			get => GetProperty(ref _selectorRecord);
			set => SetProperty(ref _selectorRecord, value);
		}

		[Ordinal(29)] 
		[RED("nodeIterator")] 
		public CInt32 NodeIterator
		{
			get => GetProperty(ref _nodeIterator);
			set => SetProperty(ref _nodeIterator, value);
		}
	}
}
