
namespace WolvenKit.RED4.Types
{
	public partial class gamedataGameplayLogicPackage_Record
	{
		[RED("animationWrapperOverrides")]
		[REDProperty(IsIgnored = true)]
		public CArray<CName> AnimationWrapperOverrides
		{
			get => GetPropertyValue<CArray<CName>>();
			set => SetPropertyValue<CArray<CName>>(value);
		}
		
		[RED("effectors")]
		[REDProperty(IsIgnored = true)]
		public CArray<TweakDBID> Effectors
		{
			get => GetPropertyValue<CArray<TweakDBID>>();
			set => SetPropertyValue<CArray<TweakDBID>>(value);
		}
		
		[RED("items")]
		[REDProperty(IsIgnored = true)]
		public CArray<TweakDBID> Items
		{
			get => GetPropertyValue<CArray<TweakDBID>>();
			set => SetPropertyValue<CArray<TweakDBID>>(value);
		}
		
		[RED("prereq")]
		[REDProperty(IsIgnored = true)]
		public CName Prereq
		{
			get => GetPropertyValue<CName>();
			set => SetPropertyValue<CName>(value);
		}
		
		[RED("stackable")]
		[REDProperty(IsIgnored = true)]
		public CBool Stackable
		{
			get => GetPropertyValue<CBool>();
			set => SetPropertyValue<CBool>(value);
		}
		
		[RED("statPools")]
		[REDProperty(IsIgnored = true)]
		public CArray<TweakDBID> StatPools
		{
			get => GetPropertyValue<CArray<TweakDBID>>();
			set => SetPropertyValue<CArray<TweakDBID>>(value);
		}
		
		[RED("stats")]
		[REDProperty(IsIgnored = true)]
		public CArray<TweakDBID> Stats
		{
			get => GetPropertyValue<CArray<TweakDBID>>();
			set => SetPropertyValue<CArray<TweakDBID>>(value);
		}
		
		[RED("UIData")]
		[REDProperty(IsIgnored = true)]
		public TweakDBID UIData
		{
			get => GetPropertyValue<TweakDBID>();
			set => SetPropertyValue<TweakDBID>(value);
		}
	}
}
