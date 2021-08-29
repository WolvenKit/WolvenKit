using static WolvenKit.RED4.Types.Enums;

namespace WolvenKit.RED4.Types
{
	[REDMeta]
	public partial class questCharacterAttack_ConditionType : questICharacterConditionType
	{
		private gameEntityReference _attackerRef;
		private gameEntityReference _targetRef;
		private CBool _isTargetPlayer;

		[Ordinal(0)] 
		[RED("attackerRef")] 
		public gameEntityReference AttackerRef
		{
			get => GetProperty(ref _attackerRef);
			set => SetProperty(ref _attackerRef, value);
		}

		[Ordinal(1)] 
		[RED("targetRef")] 
		public gameEntityReference TargetRef
		{
			get => GetProperty(ref _targetRef);
			set => SetProperty(ref _targetRef, value);
		}

		[Ordinal(2)] 
		[RED("isTargetPlayer")] 
		public CBool IsTargetPlayer
		{
			get => GetProperty(ref _isTargetPlayer);
			set => SetProperty(ref _isTargetPlayer, value);
		}
	}
}
