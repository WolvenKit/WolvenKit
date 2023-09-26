
namespace WolvenKit.RED4.Types
{
	public partial class gamedataStatModifierGroup_Record
	{
		[RED("drawBasedOnStatType")]
		[REDProperty(IsIgnored = true)]
		public CBool DrawBasedOnStatType
		{
			get => GetPropertyValue<CBool>();
			set => SetPropertyValue<CBool>(value);
		}
		
		[RED("optimiseCombinedModifiers")]
		[REDProperty(IsIgnored = true)]
		public CBool OptimiseCombinedModifiers
		{
			get => GetPropertyValue<CBool>();
			set => SetPropertyValue<CBool>(value);
		}
		
		[RED("relatedModifierGroups")]
		[REDProperty(IsIgnored = true)]
		public CArray<TweakDBID> RelatedModifierGroups
		{
			get => GetPropertyValue<CArray<TweakDBID>>();
			set => SetPropertyValue<CArray<TweakDBID>>(value);
		}
		
		[RED("saveBasedOnStatType")]
		[REDProperty(IsIgnored = true)]
		public CBool SaveBasedOnStatType
		{
			get => GetPropertyValue<CBool>();
			set => SetPropertyValue<CBool>(value);
		}
		
		[RED("statModifiers")]
		[REDProperty(IsIgnored = true)]
		public CArray<TweakDBID> StatModifiers
		{
			get => GetPropertyValue<CArray<TweakDBID>>();
			set => SetPropertyValue<CArray<TweakDBID>>(value);
		}
		
		[RED("statModsLimit")]
		[REDProperty(IsIgnored = true)]
		public CInt32 StatModsLimit
		{
			get => GetPropertyValue<CInt32>();
			set => SetPropertyValue<CInt32>(value);
		}
		
		[RED("statModsLimitModifier")]
		[REDProperty(IsIgnored = true)]
		public TweakDBID StatModsLimitModifier
		{
			get => GetPropertyValue<TweakDBID>();
			set => SetPropertyValue<TweakDBID>(value);
		}
	}
}
