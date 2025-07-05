
namespace WolvenKit.RED4.Types
{
	public partial class gamedataAddItemsEffector_Record
	{
		[RED("itemsToAdd")]
		[REDProperty(IsIgnored = true)]
		public CArray<TweakDBID> ItemsToAdd
		{
			get => GetPropertyValue<CArray<TweakDBID>>();
			set => SetPropertyValue<CArray<TweakDBID>>(value);
		}
	}
}
