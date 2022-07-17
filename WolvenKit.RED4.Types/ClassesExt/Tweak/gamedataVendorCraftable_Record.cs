
namespace WolvenKit.RED4.Types
{
	public partial class gamedataVendorCraftable_Record
	{
		[RED("craftbook")]
		[REDProperty(IsIgnored = true)]
		public TweakDBID Craftbook
		{
			get => GetPropertyValue<TweakDBID>();
			set => SetPropertyValue<TweakDBID>(value);
		}
	}
}
