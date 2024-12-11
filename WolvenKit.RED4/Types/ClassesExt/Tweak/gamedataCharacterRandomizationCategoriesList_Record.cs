
namespace WolvenKit.RED4.Types
{
	public partial class gamedataCharacterRandomizationCategoriesList_Record
	{
		[RED("list")]
		[REDProperty(IsIgnored = true)]
		public CArray<TweakDBID> List
		{
			get => GetPropertyValue<CArray<TweakDBID>>();
			set => SetPropertyValue<CArray<TweakDBID>>(value);
		}
	}
}
