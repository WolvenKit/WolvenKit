using static WolvenKit.RED4.Types.Enums;

namespace WolvenKit.RED4.Types
{
	public partial class BenchmarkResultsGameController : gameuiWidgetGameController
	{
		[Ordinal(2)] 
		[RED("exitButton")] 
		public inkWidgetReference ExitButton
		{
			get => GetPropertyValue<inkWidgetReference>();
			set => SetPropertyValue<inkWidgetReference>(value);
		}

		[Ordinal(3)] 
		[RED("settingButton")] 
		public inkWidgetReference SettingButton
		{
			get => GetPropertyValue<inkWidgetReference>();
			set => SetPropertyValue<inkWidgetReference>(value);
		}

		[Ordinal(4)] 
		[RED("leftEntriesListContainer")] 
		public inkCompoundWidgetReference LeftEntriesListContainer
		{
			get => GetPropertyValue<inkCompoundWidgetReference>();
			set => SetPropertyValue<inkCompoundWidgetReference>(value);
		}

		[Ordinal(5)] 
		[RED("rightEntriesListContainer")] 
		public inkCompoundWidgetReference RightEntriesListContainer
		{
			get => GetPropertyValue<inkCompoundWidgetReference>();
			set => SetPropertyValue<inkCompoundWidgetReference>(value);
		}

		[Ordinal(6)] 
		[RED("lineEntryName")] 
		public CName LineEntryName
		{
			get => GetPropertyValue<CName>();
			set => SetPropertyValue<CName>(value);
		}

		[Ordinal(7)] 
		[RED("highlightLineEntryName")] 
		public CName HighlightLineEntryName
		{
			get => GetPropertyValue<CName>();
			set => SetPropertyValue<CName>(value);
		}

		[Ordinal(8)] 
		[RED("sectionEntryName")] 
		public CName SectionEntryName
		{
			get => GetPropertyValue<CName>();
			set => SetPropertyValue<CName>(value);
		}

		[Ordinal(9)] 
		[RED("benchmarkSummary")] 
		public CHandle<worldBenchmarkSummary> BenchmarkSummary
		{
			get => GetPropertyValue<CHandle<worldBenchmarkSummary>>();
			set => SetPropertyValue<CHandle<worldBenchmarkSummary>>(value);
		}

		[Ordinal(10)] 
		[RED("exitRequestToken")] 
		public CHandle<inkGameNotificationToken> ExitRequestToken
		{
			get => GetPropertyValue<CHandle<inkGameNotificationToken>>();
			set => SetPropertyValue<CHandle<inkGameNotificationToken>>(value);
		}

		[Ordinal(11)] 
		[RED("settingsAcive")] 
		public CBool SettingsAcive
		{
			get => GetPropertyValue<CBool>();
			set => SetPropertyValue<CBool>(value);
		}

		public BenchmarkResultsGameController()
		{
			ExitButton = new();
			SettingButton = new();
			LeftEntriesListContainer = new();
			RightEntriesListContainer = new();
			LineEntryName = "data";
			HighlightLineEntryName = "highlight_data";
			SectionEntryName = "category";

			PostConstruct();
		}

		partial void PostConstruct();
	}
}
