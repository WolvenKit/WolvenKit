
namespace WolvenKit.RED4.Types
{
	public partial class gamedataGameplayAbility_Record
	{
		[RED("abilityPackage")]
		[REDProperty(IsIgnored = true)]
		public TweakDBID AbilityPackage
		{
			get => GetPropertyValue<TweakDBID>();
			set => SetPropertyValue<TweakDBID>(value);
		}
		
		[RED("loc_key_desc")]
		[REDProperty(IsIgnored = true)]
		public gamedataLocKeyWrapper Loc_key_desc
		{
			get => GetPropertyValue<gamedataLocKeyWrapper>();
			set => SetPropertyValue<gamedataLocKeyWrapper>(value);
		}
		
		[RED("loc_key_name")]
		[REDProperty(IsIgnored = true)]
		public gamedataLocKeyWrapper Loc_key_name
		{
			get => GetPropertyValue<gamedataLocKeyWrapper>();
			set => SetPropertyValue<gamedataLocKeyWrapper>(value);
		}
		
		[RED("prereqsForUIValidation")]
		[REDProperty(IsIgnored = true)]
		public CArray<TweakDBID> PrereqsForUIValidation
		{
			get => GetPropertyValue<CArray<TweakDBID>>();
			set => SetPropertyValue<CArray<TweakDBID>>(value);
		}
		
		[RED("prereqsForUse")]
		[REDProperty(IsIgnored = true)]
		public CArray<TweakDBID> PrereqsForUse
		{
			get => GetPropertyValue<CArray<TweakDBID>>();
			set => SetPropertyValue<CArray<TweakDBID>>(value);
		}
		
		[RED("showInCodex")]
		[REDProperty(IsIgnored = true)]
		public CBool ShowInCodex
		{
			get => GetPropertyValue<CBool>();
			set => SetPropertyValue<CBool>(value);
		}
	}
}
