using static WolvenKit.RED4.Types.Enums;

namespace WolvenKit.RED4.Types
{
	[REDMeta]
	public partial class MeleeHitSlowMoEvent : redEvent
	{
		[Ordinal(0)] 
		[RED("isStrongAttack")] 
		public CBool IsStrongAttack
		{
			get => GetPropertyValue<CBool>();
			set => SetPropertyValue<CBool>(value);
		}
	}
}
