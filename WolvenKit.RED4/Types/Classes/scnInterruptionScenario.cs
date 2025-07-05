using static WolvenKit.RED4.Types.Enums;

namespace WolvenKit.RED4.Types
{
	public partial class scnInterruptionScenario : RedBaseClass
	{
		[Ordinal(0)] 
		[RED("id")] 
		public scnInterruptionScenarioId Id
		{
			get => GetPropertyValue<scnInterruptionScenarioId>();
			set => SetPropertyValue<scnInterruptionScenarioId>(value);
		}

		[Ordinal(1)] 
		[RED("name")] 
		public CName Name
		{
			get => GetPropertyValue<CName>();
			set => SetPropertyValue<CName>(value);
		}

		[Ordinal(2)] 
		[RED("queueName")] 
		public CName QueueName
		{
			get => GetPropertyValue<CName>();
			set => SetPropertyValue<CName>(value);
		}

		[Ordinal(3)] 
		[RED("enabled")] 
		public CBool Enabled
		{
			get => GetPropertyValue<CBool>();
			set => SetPropertyValue<CBool>(value);
		}

		[Ordinal(4)] 
		[RED("talkOnReturn")] 
		public CBool TalkOnReturn
		{
			get => GetPropertyValue<CBool>();
			set => SetPropertyValue<CBool>(value);
		}

		[Ordinal(5)] 
		[RED("playInterruptLine")] 
		public CBool PlayInterruptLine
		{
			get => GetPropertyValue<CBool>();
			set => SetPropertyValue<CBool>(value);
		}

		[Ordinal(6)] 
		[RED("forcePlayReturnLine")] 
		public CBool ForcePlayReturnLine
		{
			get => GetPropertyValue<CBool>();
			set => SetPropertyValue<CBool>(value);
		}

		[Ordinal(7)] 
		[RED("interruptionSpammingSafeguard")] 
		public CBool InterruptionSpammingSafeguard
		{
			get => GetPropertyValue<CBool>();
			set => SetPropertyValue<CBool>(value);
		}

		[Ordinal(8)] 
		[RED("playingLinesBehavior")] 
		public CEnum<scnInterruptReturnLinesBehavior> PlayingLinesBehavior
		{
			get => GetPropertyValue<CEnum<scnInterruptReturnLinesBehavior>>();
			set => SetPropertyValue<CEnum<scnInterruptReturnLinesBehavior>>(value);
		}

		[Ordinal(9)] 
		[RED("postInterruptSignalTimeDelay")] 
		public CFloat PostInterruptSignalTimeDelay
		{
			get => GetPropertyValue<CFloat>();
			set => SetPropertyValue<CFloat>(value);
		}

		[Ordinal(10)] 
		[RED("postReturnSignalTimeDelay")] 
		public CFloat PostReturnSignalTimeDelay
		{
			get => GetPropertyValue<CFloat>();
			set => SetPropertyValue<CFloat>(value);
		}

		[Ordinal(11)] 
		[RED("postInterruptSignalFactCondition")] 
		public CHandle<scnInterruptFactConditionType> PostInterruptSignalFactCondition
		{
			get => GetPropertyValue<CHandle<scnInterruptFactConditionType>>();
			set => SetPropertyValue<CHandle<scnInterruptFactConditionType>>(value);
		}

		[Ordinal(12)] 
		[RED("postReturnSignalFactCondition")] 
		public CHandle<scnInterruptFactConditionType> PostReturnSignalFactCondition
		{
			get => GetPropertyValue<CHandle<scnInterruptFactConditionType>>();
			set => SetPropertyValue<CHandle<scnInterruptFactConditionType>>(value);
		}

		[Ordinal(13)] 
		[RED("interruptConditions")] 
		public CArray<CHandle<scnIInterruptCondition>> InterruptConditions
		{
			get => GetPropertyValue<CArray<CHandle<scnIInterruptCondition>>>();
			set => SetPropertyValue<CArray<CHandle<scnIInterruptCondition>>>(value);
		}

		[Ordinal(14)] 
		[RED("returnConditions")] 
		public CArray<CHandle<scnIReturnCondition>> ReturnConditions
		{
			get => GetPropertyValue<CArray<CHandle<scnIReturnCondition>>>();
			set => SetPropertyValue<CArray<CHandle<scnIReturnCondition>>>(value);
		}

		public scnInterruptionScenario()
		{
			Id = new scnInterruptionScenarioId { Id = uint.MaxValue };
			Enabled = true;
			TalkOnReturn = true;
			PlayInterruptLine = true;
			InterruptConditions = new();
			ReturnConditions = new();

			PostConstruct();
		}

		partial void PostConstruct();
	}
}
