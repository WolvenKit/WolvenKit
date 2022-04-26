using static WolvenKit.RED4.Types.Enums;

namespace WolvenKit.RED4.Types
{
	public partial class ForceShootCommandHandler : AIbehaviortaskScript
	{
		[Ordinal(0)] 
		[RED("inCommand")] 
		public CHandle<AIArgumentMapping> InCommand
		{
			get => GetPropertyValue<CHandle<AIArgumentMapping>>();
			set => SetPropertyValue<CHandle<AIArgumentMapping>>(value);
		}

		[Ordinal(1)] 
		[RED("currentCommand")] 
		public CWeakHandle<AIForceShootCommand> CurrentCommand
		{
			get => GetPropertyValue<CWeakHandle<AIForceShootCommand>>();
			set => SetPropertyValue<CWeakHandle<AIForceShootCommand>>(value);
		}

		public ForceShootCommandHandler()
		{
			PostConstruct();
		}

		partial void PostConstruct();
	}
}
