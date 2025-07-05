
namespace WolvenKit.RED4.Types
{
	public partial class gamedataGenderEntity_Record
	{
		[RED("entity")]
		[REDProperty(IsIgnored = true)]
		public CResourceAsyncReference<CResource> Entity
		{
			get => GetPropertyValue<CResourceAsyncReference<CResource>>();
			set => SetPropertyValue<CResourceAsyncReference<CResource>>(value);
		}
		
		[RED("gender")]
		[REDProperty(IsIgnored = true)]
		public TweakDBID Gender
		{
			get => GetPropertyValue<TweakDBID>();
			set => SetPropertyValue<TweakDBID>(value);
		}
		
		[RED("initial")]
		[REDProperty(IsIgnored = true)]
		public CBool Initial
		{
			get => GetPropertyValue<CBool>();
			set => SetPropertyValue<CBool>(value);
		}
		
		[RED("multiplayerEntities")]
		[REDProperty(IsIgnored = true)]
		public CArray<CResourceAsyncReference<CResource>> MultiplayerEntities
		{
			get => GetPropertyValue<CArray<CResourceAsyncReference<CResource>>>();
			set => SetPropertyValue<CArray<CResourceAsyncReference<CResource>>>(value);
		}
	}
}
