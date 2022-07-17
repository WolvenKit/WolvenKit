
namespace WolvenKit.RED4.Types
{
	public partial class gamedataLootItem_Record
	{
		[RED("itemID")]
		[REDProperty(IsIgnored = true)]
		public TweakDBID ItemID
		{
			get => GetPropertyValue<TweakDBID>();
			set => SetPropertyValue<TweakDBID>(value);
		}
	}
}
