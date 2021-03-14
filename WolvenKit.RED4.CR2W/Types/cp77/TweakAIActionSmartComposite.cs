using WolvenKit.RED4.CR2W.Reflection;
using FastMember;
using static WolvenKit.RED4.CR2W.Types.Enums;

namespace WolvenKit.RED4.CR2W.Types
{
	[REDMeta]
	public class TweakAIActionSmartComposite : TweakAIActionAbstract
	{
		private TweakDBID _smartComposite;
		private wCHandle<gamedataAIActionSmartComposite_Record> _smartCompositeRecord;
		private CBool _interruptionRequested;
		private CFloat _conditionSuccessfulCheckTimeStamp;
		private CFloat _conditionCheckTimeStamp;
		private CFloat _conditionCheckRandomizedInterval;
		private CUInt32 _iteration;
		private CInt32 _nodeIterator;
		private CInt32 _currentNodeIterator;
		private CEnum<ETweakAINodeType> _currentNodeType;
		private wCHandle<gamedataAINode_Record> _currentNode;

		[Ordinal(27)] 
		[RED("smartComposite")] 
		public TweakDBID SmartComposite
		{
			get
			{
				if (_smartComposite == null)
				{
					_smartComposite = (TweakDBID) CR2WTypeManager.Create("TweakDBID", "smartComposite", cr2w, this);
				}
				return _smartComposite;
			}
			set
			{
				if (_smartComposite == value)
				{
					return;
				}
				_smartComposite = value;
				PropertySet(this);
			}
		}

		[Ordinal(28)] 
		[RED("smartCompositeRecord")] 
		public wCHandle<gamedataAIActionSmartComposite_Record> SmartCompositeRecord
		{
			get
			{
				if (_smartCompositeRecord == null)
				{
					_smartCompositeRecord = (wCHandle<gamedataAIActionSmartComposite_Record>) CR2WTypeManager.Create("whandle:gamedataAIActionSmartComposite_Record", "smartCompositeRecord", cr2w, this);
				}
				return _smartCompositeRecord;
			}
			set
			{
				if (_smartCompositeRecord == value)
				{
					return;
				}
				_smartCompositeRecord = value;
				PropertySet(this);
			}
		}

		[Ordinal(29)] 
		[RED("interruptionRequested")] 
		public CBool InterruptionRequested
		{
			get
			{
				if (_interruptionRequested == null)
				{
					_interruptionRequested = (CBool) CR2WTypeManager.Create("Bool", "interruptionRequested", cr2w, this);
				}
				return _interruptionRequested;
			}
			set
			{
				if (_interruptionRequested == value)
				{
					return;
				}
				_interruptionRequested = value;
				PropertySet(this);
			}
		}

		[Ordinal(30)] 
		[RED("conditionSuccessfulCheckTimeStamp")] 
		public CFloat ConditionSuccessfulCheckTimeStamp
		{
			get
			{
				if (_conditionSuccessfulCheckTimeStamp == null)
				{
					_conditionSuccessfulCheckTimeStamp = (CFloat) CR2WTypeManager.Create("Float", "conditionSuccessfulCheckTimeStamp", cr2w, this);
				}
				return _conditionSuccessfulCheckTimeStamp;
			}
			set
			{
				if (_conditionSuccessfulCheckTimeStamp == value)
				{
					return;
				}
				_conditionSuccessfulCheckTimeStamp = value;
				PropertySet(this);
			}
		}

		[Ordinal(31)] 
		[RED("conditionCheckTimeStamp")] 
		public CFloat ConditionCheckTimeStamp
		{
			get
			{
				if (_conditionCheckTimeStamp == null)
				{
					_conditionCheckTimeStamp = (CFloat) CR2WTypeManager.Create("Float", "conditionCheckTimeStamp", cr2w, this);
				}
				return _conditionCheckTimeStamp;
			}
			set
			{
				if (_conditionCheckTimeStamp == value)
				{
					return;
				}
				_conditionCheckTimeStamp = value;
				PropertySet(this);
			}
		}

		[Ordinal(32)] 
		[RED("conditionCheckRandomizedInterval")] 
		public CFloat ConditionCheckRandomizedInterval
		{
			get
			{
				if (_conditionCheckRandomizedInterval == null)
				{
					_conditionCheckRandomizedInterval = (CFloat) CR2WTypeManager.Create("Float", "conditionCheckRandomizedInterval", cr2w, this);
				}
				return _conditionCheckRandomizedInterval;
			}
			set
			{
				if (_conditionCheckRandomizedInterval == value)
				{
					return;
				}
				_conditionCheckRandomizedInterval = value;
				PropertySet(this);
			}
		}

		[Ordinal(33)] 
		[RED("iteration")] 
		public CUInt32 Iteration
		{
			get
			{
				if (_iteration == null)
				{
					_iteration = (CUInt32) CR2WTypeManager.Create("Uint32", "iteration", cr2w, this);
				}
				return _iteration;
			}
			set
			{
				if (_iteration == value)
				{
					return;
				}
				_iteration = value;
				PropertySet(this);
			}
		}

		[Ordinal(34)] 
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

		[Ordinal(35)] 
		[RED("currentNodeIterator")] 
		public CInt32 CurrentNodeIterator
		{
			get
			{
				if (_currentNodeIterator == null)
				{
					_currentNodeIterator = (CInt32) CR2WTypeManager.Create("Int32", "currentNodeIterator", cr2w, this);
				}
				return _currentNodeIterator;
			}
			set
			{
				if (_currentNodeIterator == value)
				{
					return;
				}
				_currentNodeIterator = value;
				PropertySet(this);
			}
		}

		[Ordinal(36)] 
		[RED("currentNodeType")] 
		public CEnum<ETweakAINodeType> CurrentNodeType
		{
			get
			{
				if (_currentNodeType == null)
				{
					_currentNodeType = (CEnum<ETweakAINodeType>) CR2WTypeManager.Create("ETweakAINodeType", "currentNodeType", cr2w, this);
				}
				return _currentNodeType;
			}
			set
			{
				if (_currentNodeType == value)
				{
					return;
				}
				_currentNodeType = value;
				PropertySet(this);
			}
		}

		[Ordinal(37)] 
		[RED("currentNode")] 
		public wCHandle<gamedataAINode_Record> CurrentNode
		{
			get
			{
				if (_currentNode == null)
				{
					_currentNode = (wCHandle<gamedataAINode_Record>) CR2WTypeManager.Create("whandle:gamedataAINode_Record", "currentNode", cr2w, this);
				}
				return _currentNode;
			}
			set
			{
				if (_currentNode == value)
				{
					return;
				}
				_currentNode = value;
				PropertySet(this);
			}
		}

		public TweakAIActionSmartComposite(CR2WFile cr2w, CVariable parent, string name) : base(cr2w, parent, name) { }
	}
}
