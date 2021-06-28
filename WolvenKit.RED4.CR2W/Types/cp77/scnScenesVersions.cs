using WolvenKit.RED4.CR2W.Reflection;
using FastMember;
using static WolvenKit.RED4.CR2W.Types.Enums;

namespace WolvenKit.RED4.CR2W.Types
{
	[REDMeta]
	public class scnScenesVersions : CResource
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

		public scnScenesVersions(IRed4EngineFile cr2w, CVariable parent, string name) : base(cr2w, parent, name) { }
	}
}
