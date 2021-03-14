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
			get
			{
				if (_selector == null)
				{
					_selector = (TweakDBID) CR2WTypeManager.Create("TweakDBID", "selector", cr2w, this);
				}
				return _selector;
			}
			set
			{
				if (_selector == value)
				{
					return;
				}
				_selector = value;
				PropertySet(this);
			}
		}

		[Ordinal(28)] 
		[RED("selectorRecord")] 
		public wCHandle<gamedataAIActionSelector_Record> SelectorRecord
		{
			get
			{
				if (_selectorRecord == null)
				{
					_selectorRecord = (wCHandle<gamedataAIActionSelector_Record>) CR2WTypeManager.Create("whandle:gamedataAIActionSelector_Record", "selectorRecord", cr2w, this);
				}
				return _selectorRecord;
			}
			set
			{
				if (_selectorRecord == value)
				{
					return;
				}
				_selectorRecord = value;
				PropertySet(this);
			}
		}

		[Ordinal(29)] 
		[RED("nodeIterator")] 
		public CInt32 NodeIterator
		{
			get
			{
				if (_nodeIterator == null)
				{
					_nodeIterator = (CInt32) CR2WTypeManager.Create("Int32", "nodeIterator", cr2w, this);
				}
				return _nodeIterator;
			}
			set
			{
				if (_nodeIterator == value)
				{
					return;
				}
				_nodeIterator = value;
				PropertySet(this);
			}
		}

		public TweakAIActionSelector(CR2WFile cr2w, CVariable parent, string name) : base(cr2w, parent, name) { }
	}
}
