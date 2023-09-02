using static WolvenKit.RED4.Types.Enums;

namespace WolvenKit.RED4.Types
{
	public partial class gameuiMappinUIProfile : RedBaseClass
	{
		[Ordinal(0)] 
		[RED("widgetResource")] 
		public redResourceReferenceScriptToken WidgetResource
		{
			get => GetPropertyValue<redResourceReferenceScriptToken>();
			set => SetPropertyValue<redResourceReferenceScriptToken>(value);
		}

		[Ordinal(1)] 
		[RED("widgetLibraryID")] 
		public CName WidgetLibraryID
		{
			get => GetPropertyValue<CName>();
			set => SetPropertyValue<CName>(value);
		}

		[Ordinal(2)] 
		[RED("spawn")] 
		public CHandle<gamedataMappinUISpawnProfile_Record> Spawn
		{
			get => GetPropertyValue<CHandle<gamedataMappinUISpawnProfile_Record>>();
			set => SetPropertyValue<CHandle<gamedataMappinUISpawnProfile_Record>>(value);
		}

		[Ordinal(3)] 
		[RED("runtime")] 
		public CHandle<gamedataMappinUIRuntimeProfile_Record> Runtime
		{
			get => GetPropertyValue<CHandle<gamedataMappinUIRuntimeProfile_Record>>();
			set => SetPropertyValue<CHandle<gamedataMappinUIRuntimeProfile_Record>>(value);
		}

		public gameuiMappinUIProfile()
		{
			WidgetResource = new redResourceReferenceScriptToken();

			PostConstruct();
		}

		partial void PostConstruct();
	}
}
