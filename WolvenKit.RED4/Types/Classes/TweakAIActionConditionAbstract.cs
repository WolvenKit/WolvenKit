using static WolvenKit.RED4.Types.Enums;

namespace WolvenKit.RED4.Types
{
	public abstract partial class TweakAIActionConditionAbstract : AIbehaviorconditionScript
	{
		[Ordinal(0)] 
		[RED("actionRecord")] 
		public CWeakHandle<gamedataAIAction_Record> ActionRecord
		{
			get => GetPropertyValue<CWeakHandle<gamedataAIAction_Record>>();
			set => SetPropertyValue<CWeakHandle<gamedataAIAction_Record>>(value);
		}

		[Ordinal(1)] 
		[RED("actionDebugName")] 
		public CString ActionDebugName
		{
			get => GetPropertyValue<CString>();
			set => SetPropertyValue<CString>(value);
		}

		public TweakAIActionConditionAbstract()
		{
			PostConstruct();
		}

		partial void PostConstruct();
	}
}
