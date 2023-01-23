
namespace WolvenKit.RED4.Types
{
	public partial class gamedataStatusEffect_Record
	{
        [RED("additionalParam")]
		[REDProperty(IsIgnored = true)]
		public CName AdditionalParam
		{
			get => GetPropertyValue<CName>();
			set => SetPropertyValue<CName>(value);
		}
		
		[RED("AIData")]
		[REDProperty(IsIgnored = true)]
		public TweakDBID AIData
		{
			get => GetPropertyValue<TweakDBID>();
			set => SetPropertyValue<TweakDBID>(value);
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
		
		[RED("immunityStats")]
		[REDProperty(IsIgnored = true)]
		public CArray<TweakDBID> ImmunityStats
		{
			get => GetPropertyValue<CArray<TweakDBID>>();
			set => SetPropertyValue<CArray<TweakDBID>>(value);
		}
		
		[RED("isAffectedByTimeDilationNPC")]
		[REDProperty(IsIgnored = true)]
		public CBool IsAffectedByTimeDilationNPC
		{
			get => GetPropertyValue<CBool>();
			set => SetPropertyValue<CBool>(value);
		}
		
		[RED("isAffectedByTimeDilationPlayer")]
		[REDProperty(IsIgnored = true)]
		public CBool IsAffectedByTimeDilationPlayer
		{
			get => GetPropertyValue<CBool>();
			set => SetPropertyValue<CBool>(value);
		}
		
		[RED("maxStacks")]
		[REDProperty(IsIgnored = true)]
		public TweakDBID MaxStacks
		{
			get => GetPropertyValue<TweakDBID>();
			set => SetPropertyValue<TweakDBID>(value);
		}
		
		[RED("packages")]
		[REDProperty(IsIgnored = true)]
		public CArray<TweakDBID> Packages
		{
			get => GetPropertyValue<CArray<TweakDBID>>();
			set => SetPropertyValue<CArray<TweakDBID>>(value);
		}
		
		[RED("playerData")]
		[REDProperty(IsIgnored = true)]
		public TweakDBID PlayerData
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
		
		[RED("SFX")]
		[REDProperty(IsIgnored = true)]
		public CArray<TweakDBID> SFX
		{
			get => GetPropertyValue<CArray<TweakDBID>>();
			set => SetPropertyValue<CArray<TweakDBID>>(value);
		}
		
		[RED("statusEffectType")]
		[REDProperty(IsIgnored = true)]
		public TweakDBID StatusEffectType
		{
			get => GetPropertyValue<TweakDBID>();
			set => SetPropertyValue<TweakDBID>(value);
		}
		
		[RED("stopActiveSfxOnDeactivate")]
		[REDProperty(IsIgnored = true)]
		public CBool StopActiveSfxOnDeactivate
		{
			get => GetPropertyValue<CBool>();
			set => SetPropertyValue<CBool>(value);
		}
		
		[RED("uiData")]
		[REDProperty(IsIgnored = true)]
		public TweakDBID UiData
		{
			get => GetPropertyValue<TweakDBID>();
			set => SetPropertyValue<TweakDBID>(value);
		}
		
		[RED("VFX")]
		[REDProperty(IsIgnored = true)]
		public CArray<TweakDBID> VFX
		{
			get => GetPropertyValue<CArray<TweakDBID>>();
			set => SetPropertyValue<CArray<TweakDBID>>(value);
		}
	}
}
