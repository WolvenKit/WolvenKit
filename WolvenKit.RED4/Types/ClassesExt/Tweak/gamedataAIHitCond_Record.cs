
namespace WolvenKit.RED4.Types
{
	public partial class gamedataAIHitCond_Record
	{
		[RED("attackTag")]
		[REDProperty(IsIgnored = true)]
		public CName AttackTag
		{
			get => GetPropertyValue<CName>();
			set => SetPropertyValue<CName>(value);
		}
		
		[RED("cumulatedDamageThreshold")]
		[REDProperty(IsIgnored = true)]
		public CInt32 CumulatedDamageThreshold
		{
			get => GetPropertyValue<CInt32>();
			set => SetPropertyValue<CInt32>(value);
		}
		
		[RED("hitDirection")]
		[REDProperty(IsIgnored = true)]
		public CInt32 HitDirection
		{
			get => GetPropertyValue<CInt32>();
			set => SetPropertyValue<CInt32>(value);
		}
		
		[RED("hitTimeout")]
		[REDProperty(IsIgnored = true)]
		public CFloat HitTimeout
		{
			get => GetPropertyValue<CFloat>();
			set => SetPropertyValue<CFloat>(value);
		}
		
		[RED("maxHitSeverity")]
		[REDProperty(IsIgnored = true)]
		public CInt32 MaxHitSeverity
		{
			get => GetPropertyValue<CInt32>();
			set => SetPropertyValue<CInt32>(value);
		}
		
		[RED("minHitSeverity")]
		[REDProperty(IsIgnored = true)]
		public CInt32 MinHitSeverity
		{
			get => GetPropertyValue<CInt32>();
			set => SetPropertyValue<CInt32>(value);
		}
		
		[RED("target")]
		[REDProperty(IsIgnored = true)]
		public TweakDBID Target
		{
			get => GetPropertyValue<TweakDBID>();
			set => SetPropertyValue<TweakDBID>(value);
		}
		
		[RED("targetHitCount")]
		[REDProperty(IsIgnored = true)]
		public CInt32 TargetHitCount
		{
			get => GetPropertyValue<CInt32>();
			set => SetPropertyValue<CInt32>(value);
		}
	}
}
