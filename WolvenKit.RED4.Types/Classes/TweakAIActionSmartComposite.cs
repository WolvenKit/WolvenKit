using static WolvenKit.RED4.Types.Enums;

namespace WolvenKit.RED4.Types
{
	[REDMeta]
	public partial class TweakAIActionSmartComposite : TweakAIActionAbstract
	{
		[Ordinal(27)] 
		[RED("smartComposite")] 
		public TweakDBID SmartComposite
		{
			get => GetPropertyValue<TweakDBID>();
			set => SetPropertyValue<TweakDBID>(value);
		}

		[Ordinal(28)] 
		[RED("smartCompositeRecord")] 
		public CWeakHandle<gamedataAIActionSmartComposite_Record> SmartCompositeRecord
		{
			get => GetPropertyValue<CWeakHandle<gamedataAIActionSmartComposite_Record>>();
			set => SetPropertyValue<CWeakHandle<gamedataAIActionSmartComposite_Record>>(value);
		}

		[Ordinal(29)] 
		[RED("interruptionRequested")] 
		public CBool InterruptionRequested
		{
			get => GetPropertyValue<CBool>();
			set => SetPropertyValue<CBool>(value);
		}

		[Ordinal(30)] 
		[RED("conditionSuccessfulCheckTimeStamp")] 
		public CFloat ConditionSuccessfulCheckTimeStamp
		{
			get => GetPropertyValue<CFloat>();
			set => SetPropertyValue<CFloat>(value);
		}

		[Ordinal(31)] 
		[RED("conditionCheckTimeStamp")] 
		public CFloat ConditionCheckTimeStamp
		{
			get => GetPropertyValue<CFloat>();
			set => SetPropertyValue<CFloat>(value);
		}

		[Ordinal(32)] 
		[RED("conditionCheckRandomizedInterval")] 
		public CFloat ConditionCheckRandomizedInterval
		{
			get => GetPropertyValue<CFloat>();
			set => SetPropertyValue<CFloat>(value);
		}

		[Ordinal(33)] 
		[RED("iteration")] 
		public CUInt32 Iteration
		{
			get => GetPropertyValue<CUInt32>();
			set => SetPropertyValue<CUInt32>(value);
		}

		[Ordinal(34)] 
		[RED("nodeIterator")] 
		public CInt32 NodeIterator
		{
			get => GetPropertyValue<CInt32>();
			set => SetPropertyValue<CInt32>(value);
		}

		[Ordinal(35)] 
		[RED("currentNodeIterator")] 
		public CInt32 CurrentNodeIterator
		{
			get => GetPropertyValue<CInt32>();
			set => SetPropertyValue<CInt32>(value);
		}

		[Ordinal(36)] 
		[RED("currentNodeType")] 
		public CEnum<ETweakAINodeType> CurrentNodeType
		{
			get => GetPropertyValue<CEnum<ETweakAINodeType>>();
			set => SetPropertyValue<CEnum<ETweakAINodeType>>(value);
		}

		[Ordinal(37)] 
		[RED("currentNode")] 
		public CWeakHandle<gamedataAINode_Record> CurrentNode
		{
			get => GetPropertyValue<CWeakHandle<gamedataAINode_Record>>();
			set => SetPropertyValue<CWeakHandle<gamedataAINode_Record>>(value);
		}

		public TweakAIActionSmartComposite()
		{
			LookatEvents = new();
			GeneralSubActionsResults = new(8);
			PhaseSubActionsResults = new(8);
		}
	}
}
