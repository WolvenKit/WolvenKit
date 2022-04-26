using static WolvenKit.RED4.Types.Enums;

namespace WolvenKit.RED4.Types
{
	public partial class BenchmarkResultsGameController : gameuiWidgetGameController
	{
		[Ordinal(2)] 
		[RED("button")] 
		public inkWidgetReference Button
		{
			get => GetPropertyValue<inkWidgetReference>();
			set => SetPropertyValue<inkWidgetReference>(value);
		}

		[Ordinal(3)] 
		[RED("entriesListContainer")] 
		public inkCompoundWidgetReference EntriesListContainer
		{
			get => GetPropertyValue<inkCompoundWidgetReference>();
			set => SetPropertyValue<inkCompoundWidgetReference>(value);
		}

		[Ordinal(4)] 
		[RED("lineEntryName")] 
		public CName LineEntryName
		{
			get => GetPropertyValue<CName>();
			set => SetPropertyValue<CName>(value);
		}

		[Ordinal(5)] 
		[RED("sectionEntryName")] 
		public CName SectionEntryName
		{
			get => GetPropertyValue<CName>();
			set => SetPropertyValue<CName>(value);
		}

		[Ordinal(6)] 
		[RED("benchmarkSummary")] 
		public CHandle<worldBenchmarkSummary> BenchmarkSummary
		{
			get => GetPropertyValue<CHandle<worldBenchmarkSummary>>();
			set => SetPropertyValue<CHandle<worldBenchmarkSummary>>(value);
		}

		[Ordinal(7)] 
		[RED("exitRequestToken")] 
		public CHandle<inkGameNotificationToken> ExitRequestToken
		{
			get => GetPropertyValue<CHandle<inkGameNotificationToken>>();
			set => SetPropertyValue<CHandle<inkGameNotificationToken>>(value);
		}

		public BenchmarkResultsGameController()
		{
			Button = new();
			EntriesListContainer = new();

			PostConstruct();
		}

		partial void PostConstruct();
	}
}
