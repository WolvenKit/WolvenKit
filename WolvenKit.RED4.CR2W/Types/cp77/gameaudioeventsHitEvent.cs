using WolvenKit.RED4.CR2W.Reflection;
using FastMember;
using static WolvenKit.RED4.CR2W.Types.Enums;

namespace WolvenKit.RED4.CR2W.Types
{
	[REDMeta]
	public class gameaudioeventsHitEvent : redEvent
	{
		private CEnum<gamedataAttackType> _attackType;
		private Vector4 _hitPosition;
		private CName _physicsMaterial;
		private CFloat _damage;
		private CBool _isTargetPuppet;
		private CName _targetPuppetMeleeMaterial;

		[Ordinal(0)] 
		[RED("attackType")] 
		public CEnum<gamedataAttackType> AttackType
		{
			get => GetProperty(ref _attackType);
			set => SetProperty(ref _attackType, value);
		}

		[Ordinal(1)] 
		[RED("hitPosition")] 
		public Vector4 HitPosition
		{
			get => GetProperty(ref _hitPosition);
			set => SetProperty(ref _hitPosition, value);
		}

		[Ordinal(2)] 
		[RED("physicsMaterial")] 
		public CName PhysicsMaterial
		{
			get => GetProperty(ref _physicsMaterial);
			set => SetProperty(ref _physicsMaterial, value);
		}

		[Ordinal(3)] 
		[RED("damage")] 
		public CFloat Damage
		{
			get => GetProperty(ref _damage);
			set => SetProperty(ref _damage, value);
		}

		[Ordinal(4)] 
		[RED("isTargetPuppet")] 
		public CBool IsTargetPuppet
		{
			get => GetProperty(ref _isTargetPuppet);
			set => SetProperty(ref _isTargetPuppet, value);
		}

		[Ordinal(5)] 
		[RED("targetPuppetMeleeMaterial")] 
		public CName TargetPuppetMeleeMaterial
		{
			get => GetProperty(ref _targetPuppetMeleeMaterial);
			set => SetProperty(ref _targetPuppetMeleeMaterial, value);
		}

		public gameaudioeventsHitEvent(IRed4EngineFile cr2w, CVariable parent, string name) : base(cr2w, parent, name) { }
	}
}
