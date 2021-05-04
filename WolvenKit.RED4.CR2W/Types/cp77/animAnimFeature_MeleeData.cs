using WolvenKit.RED4.CR2W.Reflection;
using FastMember;
using static WolvenKit.RED4.CR2W.Types.Enums;

namespace WolvenKit.RED4.CR2W.Types
{
	[REDMeta]
	public class animAnimFeature_MeleeData : animAnimFeature
	{
		private CBool _isMeleeWeaponEquipped;
		private CFloat _attackSpeed;
		private CBool _isEquippingThrowable;
		private CBool _isTargeting;
		private CBool _isBlocking;
		private CBool _isHolding;
		private CBool _isAttacking;
		private CInt32 _attackNumber;
		private CBool _shouldHandsDisappear;
		private CBool _isSliding;
		private CFloat _deflectDuration;
		private CBool _isSafe;
		private CBool _keepRenderPlane;
		private CBool _hasDeflectAnim;
		private CBool _hasHitAnim;
		private CInt32 _attackType;
		private CBool _isParried;

		[Ordinal(0)] 
		[RED("isMeleeWeaponEquipped")] 
		public CBool IsMeleeWeaponEquipped
		{
			get => GetProperty(ref _isMeleeWeaponEquipped);
			set => SetProperty(ref _isMeleeWeaponEquipped, value);
		}

		[Ordinal(1)] 
		[RED("attackSpeed")] 
		public CFloat AttackSpeed
		{
			get => GetProperty(ref _attackSpeed);
			set => SetProperty(ref _attackSpeed, value);
		}

		[Ordinal(2)] 
		[RED("isEquippingThrowable")] 
		public CBool IsEquippingThrowable
		{
			get => GetProperty(ref _isEquippingThrowable);
			set => SetProperty(ref _isEquippingThrowable, value);
		}

		[Ordinal(3)] 
		[RED("isTargeting")] 
		public CBool IsTargeting
		{
			get => GetProperty(ref _isTargeting);
			set => SetProperty(ref _isTargeting, value);
		}

		[Ordinal(4)] 
		[RED("isBlocking")] 
		public CBool IsBlocking
		{
			get => GetProperty(ref _isBlocking);
			set => SetProperty(ref _isBlocking, value);
		}

		[Ordinal(5)] 
		[RED("isHolding")] 
		public CBool IsHolding
		{
			get => GetProperty(ref _isHolding);
			set => SetProperty(ref _isHolding, value);
		}

		[Ordinal(6)] 
		[RED("isAttacking")] 
		public CBool IsAttacking
		{
			get => GetProperty(ref _isAttacking);
			set => SetProperty(ref _isAttacking, value);
		}

		[Ordinal(7)] 
		[RED("attackNumber")] 
		public CInt32 AttackNumber
		{
			get => GetProperty(ref _attackNumber);
			set => SetProperty(ref _attackNumber, value);
		}

		[Ordinal(8)] 
		[RED("shouldHandsDisappear")] 
		public CBool ShouldHandsDisappear
		{
			get => GetProperty(ref _shouldHandsDisappear);
			set => SetProperty(ref _shouldHandsDisappear, value);
		}

		[Ordinal(9)] 
		[RED("isSliding")] 
		public CBool IsSliding
		{
			get => GetProperty(ref _isSliding);
			set => SetProperty(ref _isSliding, value);
		}

		[Ordinal(10)] 
		[RED("deflectDuration")] 
		public CFloat DeflectDuration
		{
			get => GetProperty(ref _deflectDuration);
			set => SetProperty(ref _deflectDuration, value);
		}

		[Ordinal(11)] 
		[RED("isSafe")] 
		public CBool IsSafe
		{
			get => GetProperty(ref _isSafe);
			set => SetProperty(ref _isSafe, value);
		}

		[Ordinal(12)] 
		[RED("keepRenderPlane")] 
		public CBool KeepRenderPlane
		{
			get => GetProperty(ref _keepRenderPlane);
			set => SetProperty(ref _keepRenderPlane, value);
		}

		[Ordinal(13)] 
		[RED("hasDeflectAnim")] 
		public CBool HasDeflectAnim
		{
			get => GetProperty(ref _hasDeflectAnim);
			set => SetProperty(ref _hasDeflectAnim, value);
		}

		[Ordinal(14)] 
		[RED("hasHitAnim")] 
		public CBool HasHitAnim
		{
			get => GetProperty(ref _hasHitAnim);
			set => SetProperty(ref _hasHitAnim, value);
		}

		[Ordinal(15)] 
		[RED("attackType")] 
		public CInt32 AttackType
		{
			get => GetProperty(ref _attackType);
			set => SetProperty(ref _attackType, value);
		}

		[Ordinal(16)] 
		[RED("isParried")] 
		public CBool IsParried
		{
			get => GetProperty(ref _isParried);
			set => SetProperty(ref _isParried, value);
		}

		public animAnimFeature_MeleeData(IRed4EngineFile cr2w, CVariable parent, string name) : base(cr2w, parent, name) { }
	}
}
