using WolvenKit.RED4.CR2W.Reflection;
using FastMember;
using static WolvenKit.RED4.CR2W.Types.Enums;

namespace WolvenKit.RED4.CR2W.Types
{
	[REDMeta]
	public class gameaudioRagdollSubSystem : gameaudioISoundComponentSubSystem
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

		public gameaudioRagdollSubSystem(CR2WFile cr2w, CVariable parent, string name) : base(cr2w, parent, name) { }
	}
}
