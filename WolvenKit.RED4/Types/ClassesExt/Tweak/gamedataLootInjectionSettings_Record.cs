
namespace WolvenKit.RED4.Types
{
	public partial class gamedataLootInjectionSettings_Record
	{
		[RED("brokenChance")]
		[REDProperty(IsIgnored = true)]
		public CFloat BrokenChance
		{
			get => GetPropertyValue<CFloat>();
			set => SetPropertyValue<CFloat>(value);
		}
		
		[RED("brokenOverrideChance")]
		[REDProperty(IsIgnored = true)]
		public CFloat BrokenOverrideChance
		{
			get => GetPropertyValue<CFloat>();
			set => SetPropertyValue<CFloat>(value);
		}
		
		[RED("injectedLoot")]
		[REDProperty(IsIgnored = true)]
		public TweakDBID InjectedLoot
		{
			get => GetPropertyValue<TweakDBID>();
			set => SetPropertyValue<TweakDBID>(value);
		}
		
		[RED("statsExlcudingBroken")]
		[REDProperty(IsIgnored = true)]
		public CArray<TweakDBID> StatsExlcudingBroken
		{
			get => GetPropertyValue<CArray<TweakDBID>>();
			set => SetPropertyValue<CArray<TweakDBID>>(value);
		}
		
		[RED("tagsExcludingBroken")]
		[REDProperty(IsIgnored = true)]
		public CArray<CName> TagsExcludingBroken
		{
			get => GetPropertyValue<CArray<CName>>();
			set => SetPropertyValue<CArray<CName>>(value);
		}
	}
}
