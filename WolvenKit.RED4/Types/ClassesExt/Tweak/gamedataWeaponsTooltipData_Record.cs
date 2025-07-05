
namespace WolvenKit.RED4.Types
{
	public partial class gamedataWeaponsTooltipData_Record
	{
		[RED("maxStatsValue")]
		[REDProperty(IsIgnored = true)]
		public CArray<CFloat> MaxStatsValue
		{
			get => GetPropertyValue<CArray<CFloat>>();
			set => SetPropertyValue<CArray<CFloat>>(value);
		}
		
		[RED("statsToCompare")]
		[REDProperty(IsIgnored = true)]
		public CArray<TweakDBID> StatsToCompare
		{
			get => GetPropertyValue<CArray<TweakDBID>>();
			set => SetPropertyValue<CArray<TweakDBID>>(value);
		}
	}
}
