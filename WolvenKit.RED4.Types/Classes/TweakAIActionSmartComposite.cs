using static WolvenKit.RED4.Types.Enums;

namespace WolvenKit.RED4.Types
{
	[REDMeta]
	public partial class TweakAIActionSmartComposite : TweakAIActionAbstract
	{
		private TweakDBID _smartComposite;
		private CWeakHandle<gamedataAIActionSmartComposite_Record> _smartCompositeRecord;
		private CBool _interruptionRequested;
		private CFloat _conditionSuccessfulCheckTimeStamp;
		private CFloat _conditionCheckTimeStamp;
		private CFloat _conditionCheckRandomizedInterval;
		private CUInt32 _iteration;
		private CInt32 _nodeIterator;
		private CInt32 _currentNodeIterator;
		private CEnum<ETweakAINodeType> _currentNodeType;
		private CWeakHandle<gamedataAINode_Record> _currentNode;

		[Ordinal(27)] 
		[RED("smartComposite")] 
		public TweakDBID SmartComposite
		{
			get => GetProperty(ref _smartComposite);
			set => SetProperty(ref _smartComposite, value);
		}

		[Ordinal(28)] 
		[RED("smartCompositeRecord")] 
		public CWeakHandle<gamedataAIActionSmartComposite_Record> SmartCompositeRecord
		{
			get => GetProperty(ref _smartCompositeRecord);
			set => SetProperty(ref _smartCompositeRecord, value);
		}

		[Ordinal(29)] 
		[RED("interruptionRequested")] 
		public CBool InterruptionRequested
		{
			get => GetProperty(ref _interruptionRequested);
			set => SetProperty(ref _interruptionRequested, value);
		}

		[Ordinal(30)] 
		[RED("conditionSuccessfulCheckTimeStamp")] 
		public CFloat ConditionSuccessfulCheckTimeStamp
		{
			get => GetProperty(ref _conditionSuccessfulCheckTimeStamp);
			set => SetProperty(ref _conditionSuccessfulCheckTimeStamp, value);
		}

		[Ordinal(31)] 
		[RED("conditionCheckTimeStamp")] 
		public CFloat ConditionCheckTimeStamp
		{
			get => GetProperty(ref _conditionCheckTimeStamp);
			set => SetProperty(ref _conditionCheckTimeStamp, value);
		}

		[Ordinal(32)] 
		[RED("conditionCheckRandomizedInterval")] 
		public CFloat ConditionCheckRandomizedInterval
		{
			get => GetProperty(ref _conditionCheckRandomizedInterval);
			set => SetProperty(ref _conditionCheckRandomizedInterval, value);
		}

		[Ordinal(33)] 
		[RED("iteration")] 
		public CUInt32 Iteration
		{
			get => GetProperty(ref _iteration);
			set => SetProperty(ref _iteration, value);
		}

		[Ordinal(34)] 
		[RED("nodeIterator")] 
		public CInt32 NodeIterator
		{
			get => GetProperty(ref _nodeIterator);
			set => SetProperty(ref _nodeIterator, value);
		}

		[Ordinal(35)] 
		[RED("currentNodeIterator")] 
		public CInt32 CurrentNodeIterator
		{
			get => GetProperty(ref _currentNodeIterator);
			set => SetProperty(ref _currentNodeIterator, value);
		}

		[Ordinal(36)] 
		[RED("currentNodeType")] 
		public CEnum<ETweakAINodeType> CurrentNodeType
		{
			get => GetProperty(ref _currentNodeType);
			set => SetProperty(ref _currentNodeType, value);
		}

		[Ordinal(37)] 
		[RED("currentNode")] 
		public CWeakHandle<gamedataAINode_Record> CurrentNode
		{
			get => GetProperty(ref _currentNode);
			set => SetProperty(ref _currentNode, value);
		}
	}
}
