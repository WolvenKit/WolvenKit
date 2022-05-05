
namespace WolvenKit.RED4.Types
{
	public partial class gamedataStatPoolCost_Record
	{
		[RED("costMods")]
		[REDProperty(IsIgnored = true)]
		public CArray<TweakDBID> CostMods
		{
			get => GetPropertyValue<CArray<TweakDBID>>();
			set => SetPropertyValue<CArray<TweakDBID>>(value);
		}
		
		[RED("statPool")]
		[REDProperty(IsIgnored = true)]
		public TweakDBID StatPool
		{
			get => GetPropertyValue<TweakDBID>();
			set => SetPropertyValue<TweakDBID>(value);
		}
	}
}
