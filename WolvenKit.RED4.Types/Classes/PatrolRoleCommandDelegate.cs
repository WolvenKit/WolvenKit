using static WolvenKit.RED4.Types.Enums;

namespace WolvenKit.RED4.Types
{
	[REDMeta]
	public partial class PatrolRoleCommandDelegate : AIbehaviorScriptBehaviorDelegate
	{
		private CBool _patrolWithWeapon;
		private CBool _forceAlerted;

		[Ordinal(0)] 
		[RED("patrolWithWeapon")] 
		public CBool PatrolWithWeapon
		{
			get => GetProperty(ref _patrolWithWeapon);
			set => SetProperty(ref _patrolWithWeapon, value);
		}

		[Ordinal(1)] 
		[RED("forceAlerted")] 
		public CBool ForceAlerted
		{
			get => GetProperty(ref _forceAlerted);
			set => SetProperty(ref _forceAlerted, value);
		}
	}
}
