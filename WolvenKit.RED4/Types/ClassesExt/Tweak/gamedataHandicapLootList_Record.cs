
namespace WolvenKit.RED4.Types
{
	public partial class gamedataHandicapLootList_Record
	{
		[RED("loot")]
		[REDProperty(IsIgnored = true)]
		public CArray<TweakDBID> Loot
		{
			get => GetPropertyValue<CArray<TweakDBID>>();
			set => SetPropertyValue<CArray<TweakDBID>>(value);
		}
	}
}
