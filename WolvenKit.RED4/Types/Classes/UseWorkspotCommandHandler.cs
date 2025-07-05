using static WolvenKit.RED4.Types.Enums;

namespace WolvenKit.RED4.Types
{
	public partial class UseWorkspotCommandHandler : AICommandHandlerBase
	{
		[Ordinal(1)] 
		[RED("outMoveToWorkspot")] 
		public CHandle<AIArgumentMapping> OutMoveToWorkspot
		{
			get => GetPropertyValue<CHandle<AIArgumentMapping>>();
			set => SetPropertyValue<CHandle<AIArgumentMapping>>(value);
		}

		[Ordinal(2)] 
		[RED("outForceEntryAnimName")] 
		public CHandle<AIArgumentMapping> OutForceEntryAnimName
		{
			get => GetPropertyValue<CHandle<AIArgumentMapping>>();
			set => SetPropertyValue<CHandle<AIArgumentMapping>>(value);
		}

		[Ordinal(3)] 
		[RED("outContinueInCombat")] 
		public CHandle<AIArgumentMapping> OutContinueInCombat
		{
			get => GetPropertyValue<CHandle<AIArgumentMapping>>();
			set => SetPropertyValue<CHandle<AIArgumentMapping>>(value);
		}

		public UseWorkspotCommandHandler()
		{
			PostConstruct();
		}

		partial void PostConstruct();
	}
}
