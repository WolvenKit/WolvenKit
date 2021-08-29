using static WolvenKit.RED4.Types.Enums;

namespace WolvenKit.RED4.Types
{
	[REDMeta]
	public partial class gameuiMappinUIProfile : RedBaseClass
	{
		private redResourceReferenceScriptToken _widgetResource;
		private CName _widgetLibraryID;
		private CHandle<gamedataMappinUISpawnProfile_Record> _spawn;
		private CHandle<gamedataMappinUIRuntimeProfile_Record> _runtime;

		[Ordinal(0)] 
		[RED("widgetResource")] 
		public redResourceReferenceScriptToken WidgetResource
		{
			get => GetProperty(ref _widgetResource);
			set => SetProperty(ref _widgetResource, value);
		}

		[Ordinal(1)] 
		[RED("widgetLibraryID")] 
		public CName WidgetLibraryID
		{
			get => GetProperty(ref _widgetLibraryID);
			set => SetProperty(ref _widgetLibraryID, value);
		}

		[Ordinal(2)] 
		[RED("spawn")] 
		public CHandle<gamedataMappinUISpawnProfile_Record> Spawn
		{
			get => GetProperty(ref _spawn);
			set => SetProperty(ref _spawn, value);
		}

		[Ordinal(3)] 
		[RED("runtime")] 
		public CHandle<gamedataMappinUIRuntimeProfile_Record> Runtime
		{
			get => GetProperty(ref _runtime);
			set => SetProperty(ref _runtime, value);
		}
	}
}
