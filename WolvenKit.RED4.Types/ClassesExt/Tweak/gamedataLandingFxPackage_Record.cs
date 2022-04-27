
namespace WolvenKit.RED4.Types
{
	public partial class gamedataLandingFxPackage_Record
	{
		[RED("effect")]
		[REDProperty(IsIgnored = true)]
		public CResourceAsyncReference<CResource> Effect
		{
			get => GetPropertyValue<CResourceAsyncReference<CResource>>();
			set => SetPropertyValue<CResourceAsyncReference<CResource>>(value);
		}
		
		[RED("materials")]
		[REDProperty(IsIgnored = true)]
		public CArray<TweakDBID> Materials
		{
			get => GetPropertyValue<CArray<TweakDBID>>();
			set => SetPropertyValue<CArray<TweakDBID>>(value);
		}
	}
}
