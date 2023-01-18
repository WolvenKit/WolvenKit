
namespace WolvenKit.RED4.Types
{
	public partial class gamedataCraftable_Record
	{
		[RED("craftableItem")]
		[REDProperty(IsIgnored = true)]
		public CArray<TweakDBID> CraftableItem
		{
			get => GetPropertyValue<CArray<TweakDBID>>();
			set => SetPropertyValue<CArray<TweakDBID>>(value);
		}
	}
}
