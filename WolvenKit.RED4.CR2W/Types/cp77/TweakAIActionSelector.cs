using WolvenKit.RED4.CR2W.Reflection;
using FastMember;
using static WolvenKit.RED4.CR2W.Types.Enums;

namespace WolvenKit.RED4.CR2W.Types
{
	[REDMeta]
	public class TweakAIActionSelector : TweakAIActionAbstract
	{
		private TweakDBID _selector;
		private wCHandle<gamedataAIActionSelector_Record> _selectorRecord;
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
		public wCHandle<gamedataAIActionSelector_Record> SelectorRecord
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

		public TweakAIActionSelector(IRed4EngineFile cr2w, CVariable parent, string name) : base(cr2w, parent, name) { }
	}
}
