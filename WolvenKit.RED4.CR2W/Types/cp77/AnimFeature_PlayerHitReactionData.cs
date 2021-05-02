using WolvenKit.RED4.CR2W.Reflection;
using FastMember;
using static WolvenKit.RED4.CR2W.Types.Enums;

namespace WolvenKit.RED4.CR2W.Types
{
	[REDMeta]
	public class AnimFeature_PlayerHitReactionData : animAnimFeature
	{
		private CFloat _hitDirection;
		private CFloat _hitStrength;
		private CBool _isMeleeHit;
		private CBool _isLightMeleeHit;
		private CBool _isStrongMeleeHit;
		private CBool _isQuickMeleeHit;
		private CBool _isExplosion;
		private CBool _isPressureWave;
		private CInt32 _meleeAttackDirection;

		[Ordinal(0)] 
		[RED("hitDirection")] 
		public CFloat HitDirection
		{
			get => GetProperty(ref _hitDirection);
			set => SetProperty(ref _hitDirection, value);
		}

		[Ordinal(1)] 
		[RED("hitStrength")] 
		public CFloat HitStrength
		{
			get => GetProperty(ref _hitStrength);
			set => SetProperty(ref _hitStrength, value);
		}

		[Ordinal(2)] 
		[RED("isMeleeHit")] 
		public CBool IsMeleeHit
		{
			get => GetProperty(ref _isMeleeHit);
			set => SetProperty(ref _isMeleeHit, value);
		}

		[Ordinal(3)] 
		[RED("isLightMeleeHit")] 
		public CBool IsLightMeleeHit
		{
			get => GetProperty(ref _isLightMeleeHit);
			set => SetProperty(ref _isLightMeleeHit, value);
		}

		[Ordinal(4)] 
		[RED("isStrongMeleeHit")] 
		public CBool IsStrongMeleeHit
		{
			get => GetProperty(ref _isStrongMeleeHit);
			set => SetProperty(ref _isStrongMeleeHit, value);
		}

		[Ordinal(5)] 
		[RED("isQuickMeleeHit")] 
		public CBool IsQuickMeleeHit
		{
			get => GetProperty(ref _isQuickMeleeHit);
			set => SetProperty(ref _isQuickMeleeHit, value);
		}

		[Ordinal(6)] 
		[RED("isExplosion")] 
		public CBool IsExplosion
		{
			get => GetProperty(ref _isExplosion);
			set => SetProperty(ref _isExplosion, value);
		}

		[Ordinal(7)] 
		[RED("isPressureWave")] 
		public CBool IsPressureWave
		{
			get => GetProperty(ref _isPressureWave);
			set => SetProperty(ref _isPressureWave, value);
		}

		[Ordinal(8)] 
		[RED("meleeAttackDirection")] 
		public CInt32 MeleeAttackDirection
		{
			get => GetProperty(ref _meleeAttackDirection);
			set => SetProperty(ref _meleeAttackDirection, value);
		}

		public AnimFeature_PlayerHitReactionData(IRed4EngineFile cr2w, CVariable parent, string name) : base(cr2w, parent, name) { }
	}
}
