using static WolvenKit.RED4.Types.Enums;

namespace WolvenKit.RED4.Types
{
	public partial class PatrolRoleCommandDelegate : AIbehaviorScriptBehaviorDelegate
	{
		[Ordinal(0)] 
		[RED("patrolWithWeapon")] 
		public CBool PatrolWithWeapon
		{
			get => GetPropertyValue<CBool>();
			set => SetPropertyValue<CBool>(value);
		}

		[Ordinal(1)] 
		[RED("forceAlerted")] 
		public CBool ForceAlerted
		{
			get => GetPropertyValue<CBool>();
			set => SetPropertyValue<CBool>(value);
		}

		public PatrolRoleCommandDelegate()
		{
			PostConstruct();
		}

		partial void PostConstruct();
	}
}
