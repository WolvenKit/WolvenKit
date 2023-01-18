
namespace WolvenKit.RED4.Types
{
	public partial class gamedataItemsFactoryAppearanceSuffixOrder_Record
	{
		[RED("appearanceSuffixes")]
		[REDProperty(IsIgnored = true)]
		public CArray<TweakDBID> AppearanceSuffixes
		{
			get => GetPropertyValue<CArray<TweakDBID>>();
			set => SetPropertyValue<CArray<TweakDBID>>(value);
		}
	}
}
