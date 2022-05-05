using static WolvenKit.RED4.Types.Enums;

namespace WolvenKit.RED4.Types
{
	public partial class MeleeAttackCommandHandler : AIbehaviortaskScript
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
		public CWeakHandle<AIMeleeAttackCommand> CurrentCommand
		{
			get => GetPropertyValue<CWeakHandle<AIMeleeAttackCommand>>();
			set => SetPropertyValue<CWeakHandle<AIMeleeAttackCommand>>(value);
		}

		public MeleeAttackCommandHandler()
		{
			PostConstruct();
		}

		partial void PostConstruct();
	}
}
