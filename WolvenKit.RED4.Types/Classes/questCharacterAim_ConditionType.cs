using static WolvenKit.RED4.Types.Enums;

namespace WolvenKit.RED4.Types
{
	[REDMeta]
	public partial class questCharacterAim_ConditionType : questICharacterConditionType
	{
		private CBool _isPlayer;
		private CBool _preciseAiming;
		private gameEntityReference _targetRef;

		[Ordinal(0)] 
		[RED("isPlayer")] 
		public CBool IsPlayer
		{
			get => GetProperty(ref _isPlayer);
			set => SetProperty(ref _isPlayer, value);
		}

		[Ordinal(1)] 
		[RED("preciseAiming")] 
		public CBool PreciseAiming
		{
			get => GetProperty(ref _preciseAiming);
			set => SetProperty(ref _preciseAiming, value);
		}

		[Ordinal(2)] 
		[RED("targetRef")] 
		public gameEntityReference TargetRef
		{
			get => GetProperty(ref _targetRef);
			set => SetProperty(ref _targetRef, value);
		}

		public questCharacterAim_ConditionType()
		{
			_isPlayer = true;
		}
	}
}
