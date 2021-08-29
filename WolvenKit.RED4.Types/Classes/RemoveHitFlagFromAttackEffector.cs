using static WolvenKit.RED4.Types.Enums;

namespace WolvenKit.RED4.Types
{
	[REDMeta]
	public partial class RemoveHitFlagFromAttackEffector : ModifyAttackEffector
	{
		private CEnum<hitFlag> _hitFlag;
		private CName _reason;

		[Ordinal(0)] 
		[RED("hitFlag")] 
		public CEnum<hitFlag> HitFlag
		{
			get => GetProperty(ref _hitFlag);
			set => SetProperty(ref _hitFlag, value);
		}

		[Ordinal(1)] 
		[RED("reason")] 
		public CName Reason
		{
			get => GetProperty(ref _reason);
			set => SetProperty(ref _reason, value);
		}
	}
}
