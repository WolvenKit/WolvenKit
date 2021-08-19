using WolvenKit.RED4.CR2W.Reflection;
using FastMember;
using static WolvenKit.RED4.CR2W.Types.Enums;

namespace WolvenKit.RED4.CR2W.Types
{
	[REDMeta]
	public class WeaponReadyListenerTransition : WeaponTransition
	{
		private wCHandle<gameObject> _executionOwner;
		private CArray<CHandle<redCallbackObject>> _callBackIDs;
		private CBool _beingCreated;
		private CHandle<DefaultTransitionStatListener> _statListener;
		private CHandle<DefaultTransitionStatusEffectListener> _statusEffectListener;
		private CBool _isVaulting;
		private CBool _isDodging;
		private CBool _isInWorkspot;
		private CBool _isSliding;
		private CBool _isInTakedown;
		private CBool _isUsingCombatGadget;
		private CBool _hasStatusEffectNoCombat;
		private CBool _hasStatusEffectFastForward;
		private CBool _hasStatusEffectVehicleScene;
		private CBool _hasStunnedStatusEffect;
		private CBool _hasJamStatusEffect;
		private CBool _canWeaponShootWhileVaulting;
		private CBool _canShootWhileDodging;
		private CBool _canWeaponShootWhileSliding;
		private CBool _isInSafeSceneTier;
		private CBool _weaponReadyListenerReturnValue;

		[Ordinal(3)] 
		[RED("executionOwner")] 
		public wCHandle<gameObject> ExecutionOwner
		{
			get => GetProperty(ref _executionOwner);
			set => SetProperty(ref _executionOwner, value);
		}

		[Ordinal(4)] 
		[RED("callBackIDs")] 
		public CArray<CHandle<redCallbackObject>> CallBackIDs
		{
			get => GetProperty(ref _callBackIDs);
			set => SetProperty(ref _callBackIDs, value);
		}

		[Ordinal(5)] 
		[RED("beingCreated")] 
		public CBool BeingCreated
		{
			get => GetProperty(ref _beingCreated);
			set => SetProperty(ref _beingCreated, value);
		}

		[Ordinal(6)] 
		[RED("statListener")] 
		public CHandle<DefaultTransitionStatListener> StatListener
		{
			get => GetProperty(ref _statListener);
			set => SetProperty(ref _statListener, value);
		}

		[Ordinal(7)] 
		[RED("statusEffectListener")] 
		public CHandle<DefaultTransitionStatusEffectListener> StatusEffectListener
		{
			get => GetProperty(ref _statusEffectListener);
			set => SetProperty(ref _statusEffectListener, value);
		}

		[Ordinal(8)] 
		[RED("isVaulting")] 
		public CBool IsVaulting
		{
			get => GetProperty(ref _isVaulting);
			set => SetProperty(ref _isVaulting, value);
		}

		[Ordinal(9)] 
		[RED("isDodging")] 
		public CBool IsDodging
		{
			get => GetProperty(ref _isDodging);
			set => SetProperty(ref _isDodging, value);
		}

		[Ordinal(10)] 
		[RED("isInWorkspot")] 
		public CBool IsInWorkspot
		{
			get => GetProperty(ref _isInWorkspot);
			set => SetProperty(ref _isInWorkspot, value);
		}

		[Ordinal(11)] 
		[RED("isSliding")] 
		public CBool IsSliding
		{
			get => GetProperty(ref _isSliding);
			set => SetProperty(ref _isSliding, value);
		}

		[Ordinal(12)] 
		[RED("isInTakedown")] 
		public CBool IsInTakedown
		{
			get => GetProperty(ref _isInTakedown);
			set => SetProperty(ref _isInTakedown, value);
		}

		[Ordinal(13)] 
		[RED("isUsingCombatGadget")] 
		public CBool IsUsingCombatGadget
		{
			get => GetProperty(ref _isUsingCombatGadget);
			set => SetProperty(ref _isUsingCombatGadget, value);
		}

		[Ordinal(14)] 
		[RED("hasStatusEffectNoCombat")] 
		public CBool HasStatusEffectNoCombat
		{
			get => GetProperty(ref _hasStatusEffectNoCombat);
			set => SetProperty(ref _hasStatusEffectNoCombat, value);
		}

		[Ordinal(15)] 
		[RED("hasStatusEffectFastForward")] 
		public CBool HasStatusEffectFastForward
		{
			get => GetProperty(ref _hasStatusEffectFastForward);
			set => SetProperty(ref _hasStatusEffectFastForward, value);
		}

		[Ordinal(16)] 
		[RED("hasStatusEffectVehicleScene")] 
		public CBool HasStatusEffectVehicleScene
		{
			get => GetProperty(ref _hasStatusEffectVehicleScene);
			set => SetProperty(ref _hasStatusEffectVehicleScene, value);
		}

		[Ordinal(17)] 
		[RED("hasStunnedStatusEffect")] 
		public CBool HasStunnedStatusEffect
		{
			get => GetProperty(ref _hasStunnedStatusEffect);
			set => SetProperty(ref _hasStunnedStatusEffect, value);
		}

		[Ordinal(18)] 
		[RED("hasJamStatusEffect")] 
		public CBool HasJamStatusEffect
		{
			get => GetProperty(ref _hasJamStatusEffect);
			set => SetProperty(ref _hasJamStatusEffect, value);
		}

		[Ordinal(19)] 
		[RED("canWeaponShootWhileVaulting")] 
		public CBool CanWeaponShootWhileVaulting
		{
			get => GetProperty(ref _canWeaponShootWhileVaulting);
			set => SetProperty(ref _canWeaponShootWhileVaulting, value);
		}

		[Ordinal(20)] 
		[RED("canShootWhileDodging")] 
		public CBool CanShootWhileDodging
		{
			get => GetProperty(ref _canShootWhileDodging);
			set => SetProperty(ref _canShootWhileDodging, value);
		}

		[Ordinal(21)] 
		[RED("canWeaponShootWhileSliding")] 
		public CBool CanWeaponShootWhileSliding
		{
			get => GetProperty(ref _canWeaponShootWhileSliding);
			set => SetProperty(ref _canWeaponShootWhileSliding, value);
		}

		[Ordinal(22)] 
		[RED("isInSafeSceneTier")] 
		public CBool IsInSafeSceneTier
		{
			get => GetProperty(ref _isInSafeSceneTier);
			set => SetProperty(ref _isInSafeSceneTier, value);
		}

		[Ordinal(23)] 
		[RED("weaponReadyListenerReturnValue")] 
		public CBool WeaponReadyListenerReturnValue
		{
			get => GetProperty(ref _weaponReadyListenerReturnValue);
			set => SetProperty(ref _weaponReadyListenerReturnValue, value);
		}

		public WeaponReadyListenerTransition(IRed4EngineFile cr2w, CVariable parent, string name) : base(cr2w, parent, name) { }
	}
}
