using static WolvenKit.RED4.Types.Enums;

namespace WolvenKit.RED4.Types
{
	[REDMeta]
	public partial class gamedamageHitDebugData : IScriptable
	{
		private Vector4 _sourceHitPosition;
		private Vector4 _targetHitPosition;
		private CWeakHandle<gameObject> _instigator;
		private CWeakHandle<gameObject> _source;
		private CWeakHandle<gameObject> _target;
		private CName _instigatorName;
		private CName _sourceName;
		private CName _targetName;
		private gameAttackDebugData _sourceAttackDebugData;
		private CName _sourceWeaponName;
		private CName _sourceAttackName;
		private CArray<CHandle<gamedamageDamageDebugData>> _calculatedDamages;
		private CArray<CHandle<gamedamageDamageDebugData>> _appliedDamages;
		private CName _hitType;
		private CName _hitFlags;

		[Ordinal(0)] 
		[RED("sourceHitPosition")] 
		public Vector4 SourceHitPosition
		{
			get => GetProperty(ref _sourceHitPosition);
			set => SetProperty(ref _sourceHitPosition, value);
		}

		[Ordinal(1)] 
		[RED("targetHitPosition")] 
		public Vector4 TargetHitPosition
		{
			get => GetProperty(ref _targetHitPosition);
			set => SetProperty(ref _targetHitPosition, value);
		}

		[Ordinal(2)] 
		[RED("instigator")] 
		public CWeakHandle<gameObject> Instigator
		{
			get => GetProperty(ref _instigator);
			set => SetProperty(ref _instigator, value);
		}

		[Ordinal(3)] 
		[RED("source")] 
		public CWeakHandle<gameObject> Source
		{
			get => GetProperty(ref _source);
			set => SetProperty(ref _source, value);
		}

		[Ordinal(4)] 
		[RED("target")] 
		public CWeakHandle<gameObject> Target
		{
			get => GetProperty(ref _target);
			set => SetProperty(ref _target, value);
		}

		[Ordinal(5)] 
		[RED("instigatorName")] 
		public CName InstigatorName
		{
			get => GetProperty(ref _instigatorName);
			set => SetProperty(ref _instigatorName, value);
		}

		[Ordinal(6)] 
		[RED("sourceName")] 
		public CName SourceName
		{
			get => GetProperty(ref _sourceName);
			set => SetProperty(ref _sourceName, value);
		}

		[Ordinal(7)] 
		[RED("targetName")] 
		public CName TargetName
		{
			get => GetProperty(ref _targetName);
			set => SetProperty(ref _targetName, value);
		}

		[Ordinal(8)] 
		[RED("sourceAttackDebugData")] 
		public gameAttackDebugData SourceAttackDebugData
		{
			get => GetProperty(ref _sourceAttackDebugData);
			set => SetProperty(ref _sourceAttackDebugData, value);
		}

		[Ordinal(9)] 
		[RED("sourceWeaponName")] 
		public CName SourceWeaponName
		{
			get => GetProperty(ref _sourceWeaponName);
			set => SetProperty(ref _sourceWeaponName, value);
		}

		[Ordinal(10)] 
		[RED("sourceAttackName")] 
		public CName SourceAttackName
		{
			get => GetProperty(ref _sourceAttackName);
			set => SetProperty(ref _sourceAttackName, value);
		}

		[Ordinal(11)] 
		[RED("calculatedDamages")] 
		public CArray<CHandle<gamedamageDamageDebugData>> CalculatedDamages
		{
			get => GetProperty(ref _calculatedDamages);
			set => SetProperty(ref _calculatedDamages, value);
		}

		[Ordinal(12)] 
		[RED("appliedDamages")] 
		public CArray<CHandle<gamedamageDamageDebugData>> AppliedDamages
		{
			get => GetProperty(ref _appliedDamages);
			set => SetProperty(ref _appliedDamages, value);
		}

		[Ordinal(13)] 
		[RED("hitType")] 
		public CName HitType
		{
			get => GetProperty(ref _hitType);
			set => SetProperty(ref _hitType, value);
		}

		[Ordinal(14)] 
		[RED("hitFlags")] 
		public CName HitFlags
		{
			get => GetProperty(ref _hitFlags);
			set => SetProperty(ref _hitFlags, value);
		}
	}
}
