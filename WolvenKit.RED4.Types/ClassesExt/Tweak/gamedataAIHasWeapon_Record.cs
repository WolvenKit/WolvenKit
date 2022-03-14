
namespace WolvenKit.RED4.Types
{
	public partial class gamedataAIHasWeapon_Record
	{
		[RED("invert")]
		[REDProperty(IsIgnored = true)]
		public CBool Invert
		{
			get => GetPropertyValue<CBool>();
			set => SetPropertyValue<CBool>(value);
		}
		
		[RED("itemCategory")]
		[REDProperty(IsIgnored = true)]
		public CArray<TweakDBID> ItemCategory
		{
			get => GetPropertyValue<CArray<TweakDBID>>();
			set => SetPropertyValue<CArray<TweakDBID>>(value);
		}
		
		[RED("itemTag")]
		[REDProperty(IsIgnored = true)]
		public CName ItemTag
		{
			get => GetPropertyValue<CName>();
			set => SetPropertyValue<CName>(value);
		}
		
		[RED("itemType")]
		[REDProperty(IsIgnored = true)]
		public CArray<TweakDBID> ItemType
		{
			get => GetPropertyValue<CArray<TweakDBID>>();
			set => SetPropertyValue<CArray<TweakDBID>>(value);
		}
	}
}
