using static WolvenKit.RED4.Types.Enums;

namespace WolvenKit.RED4.Types
{
	[REDMeta]
	public partial class scnScenesVersions : CResource
	{
		private CUInt32 _currentVersion;
		private CArray<scnScenesVersionsSceneChanges> _scenesChanges;

		[Ordinal(1)] 
		[RED("currentVersion")] 
		public CUInt32 CurrentVersion
		{
			get => GetProperty(ref _currentVersion);
			set => SetProperty(ref _currentVersion, value);
		}

		[Ordinal(2)] 
		[RED("scenesChanges")] 
		public CArray<scnScenesVersionsSceneChanges> ScenesChanges
		{
			get => GetProperty(ref _scenesChanges);
			set => SetProperty(ref _scenesChanges, value);
		}
	}
}
