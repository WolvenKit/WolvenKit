using static WolvenKit.RED4.Types.Enums;

namespace WolvenKit.RED4.Types
{
	public partial class CreateAIQuickHackActionEvent : redEvent
	{
		[Ordinal(0)] 
		[RED("requester")] 
		public entEntityID Requester
		{
			get => GetPropertyValue<entEntityID>();
			set => SetPropertyValue<entEntityID>(value);
		}

		[Ordinal(1)] 
		[RED("objectActionID")] 
		public TweakDBID ObjectActionID
		{
			get => GetPropertyValue<TweakDBID>();
			set => SetPropertyValue<TweakDBID>(value);
		}

		[Ordinal(2)] 
		[RED("puppetPS")] 
		public CHandle<ScriptedPuppetPS> PuppetPS
		{
			get => GetPropertyValue<CHandle<ScriptedPuppetPS>>();
			set => SetPropertyValue<CHandle<ScriptedPuppetPS>>(value);
		}

		public CreateAIQuickHackActionEvent()
		{
			Requester = new entEntityID();

			PostConstruct();
		}

		partial void PostConstruct();
	}
}
