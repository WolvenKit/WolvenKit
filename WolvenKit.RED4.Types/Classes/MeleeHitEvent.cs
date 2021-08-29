using static WolvenKit.RED4.Types.Enums;

namespace WolvenKit.RED4.Types
{
	[REDMeta]
	public partial class MeleeHitEvent : redEvent
	{
		private CWeakHandle<gameObject> _instigator;
		private CWeakHandle<gameObject> _target;
		private CBool _isStrongAttack;
		private CBool _hitBlocked;

		[Ordinal(0)] 
		[RED("instigator")] 
		public CWeakHandle<gameObject> Instigator
		{
			get => GetProperty(ref _instigator);
			set => SetProperty(ref _instigator, value);
		}

		[Ordinal(1)] 
		[RED("target")] 
		public CWeakHandle<gameObject> Target
		{
			get => GetProperty(ref _target);
			set => SetProperty(ref _target, value);
		}

		[Ordinal(2)] 
		[RED("isStrongAttack")] 
		public CBool IsStrongAttack
		{
			get => GetProperty(ref _isStrongAttack);
			set => SetProperty(ref _isStrongAttack, value);
		}

		[Ordinal(3)] 
		[RED("hitBlocked")] 
		public CBool HitBlocked
		{
			get => GetProperty(ref _hitBlocked);
			set => SetProperty(ref _hitBlocked, value);
		}
	}
}
