
namespace WolvenKit.RED4.Types
{
	public partial class gamedataUIStatsMap_Record
	{
		[RED("primaryStats")]
		[REDProperty(IsIgnored = true)]
		public CArray<TweakDBID> PrimaryStats
		{
			get => GetPropertyValue<CArray<TweakDBID>>();
			set => SetPropertyValue<CArray<TweakDBID>>(value);
		}
		
		[RED("secondaryStats")]
		[REDProperty(IsIgnored = true)]
		public CArray<TweakDBID> SecondaryStats
		{
			get => GetPropertyValue<CArray<TweakDBID>>();
			set => SetPropertyValue<CArray<TweakDBID>>(value);
		}
		
		[RED("statsToCompare")]
		[REDProperty(IsIgnored = true)]
		public CArray<TweakDBID> StatsToCompare
		{
			get => GetPropertyValue<CArray<TweakDBID>>();
			set => SetPropertyValue<CArray<TweakDBID>>(value);
		}
		
		[RED("typesToCompareWith")]
		[REDProperty(IsIgnored = true)]
		public CArray<TweakDBID> TypesToCompareWith
		{
			get => GetPropertyValue<CArray<TweakDBID>>();
			set => SetPropertyValue<CArray<TweakDBID>>(value);
		}
	}
}
