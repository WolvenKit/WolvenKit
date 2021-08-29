using static WolvenKit.RED4.Types.Enums;

namespace WolvenKit.RED4.Types
{
	[REDMeta]
	public partial class MeleeHitSlowMoEvent : redEvent
	{
		private CBool _isStrongAttack;

		[Ordinal(0)] 
		[RED("isStrongAttack")] 
		public CBool IsStrongAttack
		{
			get => GetProperty(ref _isStrongAttack);
			set => SetProperty(ref _isStrongAttack, value);
		}
	}
}
