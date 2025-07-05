
namespace WolvenKit.RED4.Types
{
	public partial class gamedataItemCost_Record
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
