using static WolvenKit.RED4.Types.Enums;

namespace WolvenKit.RED4.Types
{
	public partial class AIbehaviorWaitingMountCommandConditionDefinition : AIbehaviorConditionDefinition
	{
		[Ordinal(1)] 
		[RED("requestArgument")] 
		public CHandle<AIArgumentMapping> RequestArgument
		{
			get => GetPropertyValue<CHandle<AIArgumentMapping>>();
			set => SetPropertyValue<CHandle<AIArgumentMapping>>(value);
		}

		[Ordinal(2)] 
		[RED("callbackName")] 
		public CName CallbackName
		{
			get => GetPropertyValue<CName>();
			set => SetPropertyValue<CName>(value);
		}

		public AIbehaviorWaitingMountCommandConditionDefinition()
		{
			CallbackName = "OnMountRequest";

			PostConstruct();
		}

		partial void PostConstruct();
	}
}
