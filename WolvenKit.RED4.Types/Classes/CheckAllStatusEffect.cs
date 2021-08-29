using static WolvenKit.RED4.Types.Enums;

namespace WolvenKit.RED4.Types
{
	[REDMeta]
	public partial class CheckAllStatusEffect : AIStatusEffectCondition
	{
		private CName _behaviorArgumentNameTag;
		private CName _behaviorArgumentFloatPriority;
		private CName _behaviorArgumentNameFlag;

		[Ordinal(0)] 
		[RED("behaviorArgumentNameTag")] 
		public CName BehaviorArgumentNameTag
		{
			get => GetProperty(ref _behaviorArgumentNameTag);
			set => SetProperty(ref _behaviorArgumentNameTag, value);
		}

		[Ordinal(1)] 
		[RED("behaviorArgumentFloatPriority")] 
		public CName BehaviorArgumentFloatPriority
		{
			get => GetProperty(ref _behaviorArgumentFloatPriority);
			set => SetProperty(ref _behaviorArgumentFloatPriority, value);
		}

		[Ordinal(2)] 
		[RED("behaviorArgumentNameFlag")] 
		public CName BehaviorArgumentNameFlag
		{
			get => GetProperty(ref _behaviorArgumentNameFlag);
			set => SetProperty(ref _behaviorArgumentNameFlag, value);
		}
	}
}
