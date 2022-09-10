
namespace WolvenKit.RED4.Types
{
	public partial class gamedataStatusEffect_Record
	{
		[RED("actionRestriction")]
		[REDProperty(IsIgnored = true)]
		public TweakDBID ActionRestriction
		{
			get => GetPropertyValue<TweakDBID>();
			set => SetPropertyValue<TweakDBID>(value);
		}
		
		[RED("additionalParam")]
		[REDProperty(IsIgnored = true)]
		public CName AdditionalParam
		{
			get => GetPropertyValue<CName>();
			set => SetPropertyValue<CName>(value);
		}
		
		[RED("duration")]
		[REDProperty(IsIgnored = true)]
		public TweakDBID Duration
		{
			get => GetPropertyValue<TweakDBID>();
			set => SetPropertyValue<TweakDBID>(value);
		}
		
		[RED("dynamicDuration")]
		[REDProperty(IsIgnored = true)]
		public CBool DynamicDuration
		{
			get => GetPropertyValue<CBool>();
			set => SetPropertyValue<CBool>(value);
		}
		
		[RED("gameplayTags")]
		[REDProperty(IsIgnored = true)]
		public CArray<CName> GameplayTags
		{
			get => GetPropertyValue<CArray<CName>>();
			set => SetPropertyValue<CArray<CName>>(value);
		}
		
		[RED("maxStacks")]
		[REDProperty(IsIgnored = true)]
		public TweakDBID MaxStacks
		{
			get => GetPropertyValue<TweakDBID>();
			set => SetPropertyValue<TweakDBID>(value);
		}
		
		[RED("removeAllStacksWhenDurationEnds")]
		[REDProperty(IsIgnored = true)]
		public CBool RemoveAllStacksWhenDurationEnds
		{
			get => GetPropertyValue<CBool>();
			set => SetPropertyValue<CBool>(value);
		}
		
		[RED("removeAllStacksWhenDurationEndsStatModifiers")]
		[REDProperty(IsIgnored = true)]
		public TweakDBID RemoveAllStacksWhenDurationEndsStatModifiers
		{
			get => GetPropertyValue<TweakDBID>();
			set => SetPropertyValue<TweakDBID>(value);
		}
		
		[RED("removeOnStoryTier")]
		[REDProperty(IsIgnored = true)]
		public CBool RemoveOnStoryTier
		{
			get => GetPropertyValue<CBool>();
			set => SetPropertyValue<CBool>(value);
		}
		
		[RED("replicated")]
		[REDProperty(IsIgnored = true)]
		public CBool Replicated
		{
			get => GetPropertyValue<CBool>();
			set => SetPropertyValue<CBool>(value);
		}
		
		[RED("savable")]
		[REDProperty(IsIgnored = true)]
		public CBool Savable
		{
			get => GetPropertyValue<CBool>();
			set => SetPropertyValue<CBool>(value);
		}
		
		[RED("statusEffectType")]
		[REDProperty(IsIgnored = true)]
		public TweakDBID StatusEffectType
		{
			get => GetPropertyValue<TweakDBID>();
			set => SetPropertyValue<TweakDBID>(value);
		}
	}
}
