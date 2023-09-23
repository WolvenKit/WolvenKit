using static WolvenKit.RED4.Types.Enums;

namespace WolvenKit.RED4.Types
{
	public partial class TweakAIActionSmartComposite : TweakAIActionAbstract
	{
		[Ordinal(37)] 
		[RED("smartComposite")] 
		public TweakDBID SmartComposite
		{
			get => GetPropertyValue<TweakDBID>();
			set => SetPropertyValue<TweakDBID>(value);
		}

		[Ordinal(38)] 
		[RED("smartCompositeRecord")] 
		public CWeakHandle<gamedataAIActionSmartComposite_Record> SmartCompositeRecord
		{
			get => GetPropertyValue<CWeakHandle<gamedataAIActionSmartComposite_Record>>();
			set => SetPropertyValue<CWeakHandle<gamedataAIActionSmartComposite_Record>>(value);
		}

		[Ordinal(39)] 
		[RED("interruptionRequested")] 
		public CBool InterruptionRequested
		{
			get => GetPropertyValue<CBool>();
			set => SetPropertyValue<CBool>(value);
		}

		[Ordinal(40)] 
		[RED("conditionSuccessfulCheckTimeStamp")] 
		public CFloat ConditionSuccessfulCheckTimeStamp
		{
			get => GetPropertyValue<CFloat>();
			set => SetPropertyValue<CFloat>(value);
		}

		[Ordinal(41)] 
		[RED("conditionCheckTimeStamp")] 
		public CFloat ConditionCheckTimeStamp
		{
			get => GetPropertyValue<CFloat>();
			set => SetPropertyValue<CFloat>(value);
		}

		[Ordinal(42)] 
		[RED("iteration")] 
		public CUInt32 Iteration
		{
			get => GetPropertyValue<CUInt32>();
			set => SetPropertyValue<CUInt32>(value);
		}

		[Ordinal(43)] 
		[RED("nodeIterator")] 
		public CInt32 NodeIterator
		{
			get => GetPropertyValue<CInt32>();
			set => SetPropertyValue<CInt32>(value);
		}

		[Ordinal(44)] 
		[RED("currentNodeIterator")] 
		public CInt32 CurrentNodeIterator
		{
			get => GetPropertyValue<CInt32>();
			set => SetPropertyValue<CInt32>(value);
		}

		[Ordinal(45)] 
		[RED("currentNodeType")] 
		public CEnum<ETweakAINodeType> CurrentNodeType
		{
			get => GetPropertyValue<CEnum<ETweakAINodeType>>();
			set => SetPropertyValue<CEnum<ETweakAINodeType>>(value);
		}

		[Ordinal(46)] 
		[RED("currentNode")] 
		public CWeakHandle<gamedataAINode_Record> CurrentNode
		{
			get => GetPropertyValue<CWeakHandle<gamedataAINode_Record>>();
			set => SetPropertyValue<CWeakHandle<gamedataAINode_Record>>(value);
		}

		public TweakAIActionSmartComposite()
		{
			PostConstruct();
		}

		partial void PostConstruct();
	}
}
