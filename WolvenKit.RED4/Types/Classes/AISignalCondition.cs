using static WolvenKit.RED4.Types.Enums;

namespace WolvenKit.RED4.Types
{
	public abstract partial class AISignalCondition : AIbehaviorconditionScript
	{
		[Ordinal(0)] 
		[RED("requiredFlags")] 
		public CArray<CEnum<AISignalFlags>> RequiredFlags
		{
			get => GetPropertyValue<CArray<CEnum<AISignalFlags>>>();
			set => SetPropertyValue<CArray<CEnum<AISignalFlags>>>(value);
		}

		[Ordinal(1)] 
		[RED("consumesSignal")] 
		public CBool ConsumesSignal
		{
			get => GetPropertyValue<CBool>();
			set => SetPropertyValue<CBool>(value);
		}

		[Ordinal(2)] 
		[RED("activated")] 
		public CBool Activated
		{
			get => GetPropertyValue<CBool>();
			set => SetPropertyValue<CBool>(value);
		}

		[Ordinal(3)] 
		[RED("executingSignal")] 
		public AIGateSignal ExecutingSignal
		{
			get => GetPropertyValue<AIGateSignal>();
			set => SetPropertyValue<AIGateSignal>(value);
		}

		[Ordinal(4)] 
		[RED("executingSignalId")] 
		public CUInt32 ExecutingSignalId
		{
			get => GetPropertyValue<CUInt32>();
			set => SetPropertyValue<CUInt32>(value);
		}

		public AISignalCondition()
		{
			PostConstruct();
		}

		partial void PostConstruct();
	}
}
