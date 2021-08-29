using static WolvenKit.RED4.Types.Enums;

namespace WolvenKit.RED4.Types
{
	[REDMeta]
	public partial class AddHitFlagToAttackEffector : ModifyAttackEffector
	{
		private CEnum<hitFlag> _hitFlag;

		[Ordinal(0)] 
		[RED("hitFlag")] 
		public CEnum<hitFlag> HitFlag
		{
			get => GetProperty(ref _hitFlag);
			set => SetProperty(ref _hitFlag, value);
		}
	}
}
