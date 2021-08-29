using static WolvenKit.RED4.Types.Enums;

namespace WolvenKit.RED4.Types
{
	[REDMeta]
	public partial class gameaudioRagdollSubSystem : gameaudioISoundComponentSubSystem
	{
		private CName _defaultMaterialMetadata;
		private CName _customDismembermentSettings;
		private CName _lookupMatrixName;

		[Ordinal(0)] 
		[RED("defaultMaterialMetadata")] 
		public CName DefaultMaterialMetadata
		{
			get => GetProperty(ref _defaultMaterialMetadata);
			set => SetProperty(ref _defaultMaterialMetadata, value);
		}

		[Ordinal(1)] 
		[RED("customDismembermentSettings")] 
		public CName CustomDismembermentSettings
		{
			get => GetProperty(ref _customDismembermentSettings);
			set => SetProperty(ref _customDismembermentSettings, value);
		}

		[Ordinal(2)] 
		[RED("lookupMatrixName")] 
		public CName LookupMatrixName
		{
			get => GetProperty(ref _lookupMatrixName);
			set => SetProperty(ref _lookupMatrixName, value);
		}
	}
}
