
namespace WolvenKit.RED4.Types
{
	public partial class gamedataItemCost_Record
	{
		[RED("costMods")]
		[REDProperty(IsIgnored = true)]
		public CArray<TweakDBID> CostMods
		{
			get => GetPropertyValue<CArray<TweakDBID>>();
			set => SetPropertyValue<CArray<TweakDBID>>(value);
		}
		
		[RED("item")]
		[REDProperty(IsIgnored = true)]
		public TweakDBID Item
		{
			get => GetPropertyValue<TweakDBID>();
			set => SetPropertyValue<TweakDBID>(value);
		}
	}
}
