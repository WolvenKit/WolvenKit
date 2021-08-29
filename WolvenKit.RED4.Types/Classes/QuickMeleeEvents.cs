using static WolvenKit.RED4.Types.Enums;

namespace WolvenKit.RED4.Types
{
	[REDMeta]
	public partial class QuickMeleeEvents : WeaponEventsTransition
	{
		private CHandle<gameEffectInstance> _gameEffect;
		private CWeakHandle<gameObject> _targetObject;
		private CHandle<entIPlacedComponent> _targetComponent;
		private CBool _quickMeleeAttackCreated;
		private QuickMeleeAttackData _quickMeleeAttackData;

		[Ordinal(3)] 
		[RED("gameEffect")] 
		public CHandle<gameEffectInstance> GameEffect
		{
			get => GetProperty(ref _gameEffect);
			set => SetProperty(ref _gameEffect, value);
		}

		[Ordinal(4)] 
		[RED("targetObject")] 
		public CWeakHandle<gameObject> TargetObject
		{
			get => GetProperty(ref _targetObject);
			set => SetProperty(ref _targetObject, value);
		}

		[Ordinal(5)] 
		[RED("targetComponent")] 
		public CHandle<entIPlacedComponent> TargetComponent
		{
			get => GetProperty(ref _targetComponent);
			set => SetProperty(ref _targetComponent, value);
		}

		[Ordinal(6)] 
		[RED("quickMeleeAttackCreated")] 
		public CBool QuickMeleeAttackCreated
		{
			get => GetProperty(ref _quickMeleeAttackCreated);
			set => SetProperty(ref _quickMeleeAttackCreated, value);
		}

		[Ordinal(7)] 
		[RED("quickMeleeAttackData")] 
		public QuickMeleeAttackData QuickMeleeAttackData
		{
			get => GetProperty(ref _quickMeleeAttackData);
			set => SetProperty(ref _quickMeleeAttackData, value);
		}
	}
}
