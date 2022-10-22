
namespace WolvenKit.RED4.Types
{
	public partial class gamedataWeakspot_Record
	{
		[RED("gameplayTags")]
		[REDProperty(IsIgnored = true)]
		public CArray<CName> GameplayTags
		{
			get => GetPropertyValue<CArray<CName>>();
			set => SetPropertyValue<CArray<CName>>(value);
		}
		
		[RED("onDestroyedEffectors")]
		[REDProperty(IsIgnored = true)]
		public CArray<TweakDBID> OnDestroyedEffectors
		{
			get => GetPropertyValue<CArray<TweakDBID>>();
			set => SetPropertyValue<CArray<TweakDBID>>(value);
		}
		
		[RED("slotToAttach")]
		[REDProperty(IsIgnored = true)]
		public TweakDBID SlotToAttach
		{
			get => GetPropertyValue<TweakDBID>();
			set => SetPropertyValue<TweakDBID>(value);
		}
		
		[RED("validCharacterAppearances")]
		[REDProperty(IsIgnored = true)]
		public CArray<CName> ValidCharacterAppearances
		{
			get => GetPropertyValue<CArray<CName>>();
			set => SetPropertyValue<CArray<CName>>(value);
		}
	}
}
