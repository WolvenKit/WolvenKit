
namespace WolvenKit.RED4.Types
{
	public partial class gamedataVendorItem_Record
	{
		[RED("item")]
		[REDProperty(IsIgnored = true)]
		public TweakDBID Item
		{
			get => GetPropertyValue<TweakDBID>();
			set => SetPropertyValue<TweakDBID>(value);
		}
	}
}
