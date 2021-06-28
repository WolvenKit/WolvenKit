using WolvenKit.RED4.CR2W.Reflection;
using FastMember;
using static WolvenKit.RED4.CR2W.Types.Enums;

namespace WolvenKit.RED4.CR2W.Types
{
	[REDMeta]
	public class QuickMeleeAttackData : CVariable
	{
		private CFloat _attackGameEffectDelay;
		private CFloat _attackGameEffectDuration;
		private CFloat _attackRange;
		private CBool _forcePlayerToStand;
		private CBool _shouldAdjust;
		private CFloat _adjustmentRange;
		private CFloat _adjustmentDuration;
		private CFloat _adjustmentRadius;
		private CName _adjustmentCurve;
		private CFloat _cooldown;
		private CFloat _duration;

		[Ordinal(0)] 
		[RED("attackGameEffectDelay")] 
		public CFloat AttackGameEffectDelay
		{
			get => GetProperty(ref _attackGameEffectDelay);
			set => SetProperty(ref _attackGameEffectDelay, value);
		}

		[Ordinal(1)] 
		[RED("attackGameEffectDuration")] 
		public CFloat AttackGameEffectDuration
		{
			get => GetProperty(ref _attackGameEffectDuration);
			set => SetProperty(ref _attackGameEffectDuration, value);
		}

		[Ordinal(2)] 
		[RED("attackRange")] 
		public CFloat AttackRange
		{
			get => GetProperty(ref _attackRange);
			set => SetProperty(ref _attackRange, value);
		}

		[Ordinal(3)] 
		[RED("forcePlayerToStand")] 
		public CBool ForcePlayerToStand
		{
			get => GetProperty(ref _forcePlayerToStand);
			set => SetProperty(ref _forcePlayerToStand, value);
		}

		[Ordinal(4)] 
		[RED("shouldAdjust")] 
		public CBool ShouldAdjust
		{
			get => GetProperty(ref _shouldAdjust);
			set => SetProperty(ref _shouldAdjust, value);
		}

		[Ordinal(5)] 
		[RED("adjustmentRange")] 
		public CFloat AdjustmentRange
		{
			get => GetProperty(ref _adjustmentRange);
			set => SetProperty(ref _adjustmentRange, value);
		}

		[Ordinal(6)] 
		[RED("adjustmentDuration")] 
		public CFloat AdjustmentDuration
		{
			get => GetProperty(ref _adjustmentDuration);
			set => SetProperty(ref _adjustmentDuration, value);
		}

		[Ordinal(7)] 
		[RED("adjustmentRadius")] 
		public CFloat AdjustmentRadius
		{
			get => GetProperty(ref _adjustmentRadius);
			set => SetProperty(ref _adjustmentRadius, value);
		}

		[Ordinal(8)] 
		[RED("adjustmentCurve")] 
		public CName AdjustmentCurve
		{
			get => GetProperty(ref _adjustmentCurve);
			set => SetProperty(ref _adjustmentCurve, value);
		}

		[Ordinal(9)] 
		[RED("cooldown")] 
		public CFloat Cooldown
		{
			get => GetProperty(ref _cooldown);
			set => SetProperty(ref _cooldown, value);
		}

		[Ordinal(10)] 
		[RED("duration")] 
		public CFloat Duration
		{
			get => GetProperty(ref _duration);
			set => SetProperty(ref _duration, value);
		}

		public QuickMeleeAttackData(IRed4EngineFile cr2w, CVariable parent, string name) : base(cr2w, parent, name) { }
	}
}
