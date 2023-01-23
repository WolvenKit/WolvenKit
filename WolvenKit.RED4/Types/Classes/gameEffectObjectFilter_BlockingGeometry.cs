using static WolvenKit.RED4.Types.Enums;

namespace WolvenKit.RED4.Types
{
	public partial class gameEffectObjectFilter_BlockingGeometry : gameEffectObjectGroupFilter
	{
		[Ordinal(0)] 
		[RED("inclusive")] 
		public CBool Inclusive
		{
			get => GetPropertyValue<CBool>();
			set => SetPropertyValue<CBool>(value);
		}

		[Ordinal(1)] 
		[RED("sortQueryResultsByDistance")] 
		public CBool SortQueryResultsByDistance
		{
			get => GetPropertyValue<CBool>();
			set => SetPropertyValue<CBool>(value);
		}

		public gameEffectObjectFilter_BlockingGeometry()
		{
			Inclusive = true;
			SortQueryResultsByDistance = true;

			PostConstruct();
		}

		partial void PostConstruct();
	}
}
