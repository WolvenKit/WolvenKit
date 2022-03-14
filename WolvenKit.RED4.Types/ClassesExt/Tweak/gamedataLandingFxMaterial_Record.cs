
namespace WolvenKit.RED4.Types
{
	public partial class gamedataLandingFxMaterial_Record
	{
		[RED("effect")]
		[REDProperty(IsIgnored = true)]
		public CResourceAsyncReference<CResource> Effect
		{
			get => GetPropertyValue<CResourceAsyncReference<CResource>>();
			set => SetPropertyValue<CResourceAsyncReference<CResource>>(value);
		}
		
		[RED("material")]
		[REDProperty(IsIgnored = true)]
		public TweakDBID Material
		{
			get => GetPropertyValue<TweakDBID>();
			set => SetPropertyValue<TweakDBID>(value);
		}
	}
}
