
namespace WolvenKit.RED4.Types
{
	public partial class gamedataObjectActionCost_Record
	{
		[RED("costMods")]
		[REDProperty(IsIgnored = true)]
		public CArray<TweakDBID> CostMods
		{
			get => GetPropertyValue<CArray<TweakDBID>>();
			set => SetPropertyValue<CArray<TweakDBID>>(value);
		}
	}
}
