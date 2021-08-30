using static WolvenKit.RED4.Types.Enums;

namespace WolvenKit.RED4.Types
{
	[REDMeta]
	public partial class questVision_ConditionType : questISensesConditionType
	{
		private gameEntityReference _observerPuppetRef;
		private gameEntityReference _observedTargetRef;
		private CBool _isObservedTargetPlayer;
		private CBool _inverted;
		private CBool _isInstant;

		[Ordinal(0)] 
		[RED("observerPuppetRef")] 
		public gameEntityReference ObserverPuppetRef
		{
			get => GetProperty(ref _observerPuppetRef);
			set => SetProperty(ref _observerPuppetRef, value);
		}

		[Ordinal(1)] 
		[RED("observedTargetRef")] 
		public gameEntityReference ObservedTargetRef
		{
			get => GetProperty(ref _observedTargetRef);
			set => SetProperty(ref _observedTargetRef, value);
		}

		[Ordinal(2)] 
		[RED("isObservedTargetPlayer")] 
		public CBool IsObservedTargetPlayer
		{
			get => GetProperty(ref _isObservedTargetPlayer);
			set => SetProperty(ref _isObservedTargetPlayer, value);
		}

		[Ordinal(3)] 
		[RED("inverted")] 
		public CBool Inverted
		{
			get => GetProperty(ref _inverted);
			set => SetProperty(ref _inverted, value);
		}

		[Ordinal(4)] 
		[RED("isInstant")] 
		public CBool IsInstant
		{
			get => GetProperty(ref _isInstant);
			set => SetProperty(ref _isInstant, value);
		}

		public questVision_ConditionType()
		{
			_isObservedTargetPlayer = true;
			_isInstant = true;
		}
	}
}
