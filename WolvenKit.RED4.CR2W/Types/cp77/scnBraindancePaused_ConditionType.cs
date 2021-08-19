using WolvenKit.RED4.CR2W.Reflection;
using FastMember;
using static WolvenKit.RED4.CR2W.Types.Enums;

namespace WolvenKit.RED4.CR2W.Types
{
	[REDMeta]
	public class scnBraindancePaused_ConditionType : scnIBraindanceConditionType
	{
		private raRef<scnSceneResource> _sceneFile;
		private CEnum<scnSceneVersionCheck> _sceneVersion;

		[Ordinal(0)] 
		[RED("sceneFile")] 
		public raRef<scnSceneResource> SceneFile
		{
			get => GetProperty(ref _sceneFile);
			set => SetProperty(ref _sceneFile, value);
		}

		[Ordinal(1)] 
		[RED("SceneVersion")] 
		public CEnum<scnSceneVersionCheck> SceneVersion
		{
			get => GetProperty(ref _sceneVersion);
			set => SetProperty(ref _sceneVersion, value);
		}

		public scnBraindancePaused_ConditionType(IRed4EngineFile cr2w, CVariable parent, string name) : base(cr2w, parent, name) { }
	}
}
