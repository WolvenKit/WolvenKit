using static WolvenKit.RED4.Types.Enums;

namespace WolvenKit.RED4.Types
{
	public partial class ExecutePuppetActionEvent : redEvent
	{
		[Ordinal(0)] 
		[RED("actionID")] 
		public TweakDBID ActionID
		{
			get => GetPropertyValue<TweakDBID>();
			set => SetPropertyValue<TweakDBID>(value);
		}

		[Ordinal(1)] 
		[RED("action")] 
		public CHandle<PuppetAction> Action
		{
			get => GetPropertyValue<CHandle<PuppetAction>>();
			set => SetPropertyValue<CHandle<PuppetAction>>(value);
		}

		public ExecutePuppetActionEvent()
		{
			PostConstruct();
		}

		partial void PostConstruct();
	}
}
