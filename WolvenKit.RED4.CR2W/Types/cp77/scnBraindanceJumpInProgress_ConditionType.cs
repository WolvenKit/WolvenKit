using WolvenKit.RED4.CR2W.Reflection;
using FastMember;
using static WolvenKit.RED4.CR2W.Types.Enums;

namespace WolvenKit.RED4.CR2W.Types
{
	[REDMeta]
	public class scnBraindanceJumpInProgress_ConditionType : scnIBraindanceConditionType
	{
		private CBool _inProgress;
		private raRef<scnSceneResource> _sceneFile;
		private CEnum<scnSceneVersionCheck> _sceneVersion;

		[Ordinal(0)] 
		[RED("inProgress")] 
		public CBool InProgress
		{
			get => GetProperty(ref _inProgress);
			set => SetProperty(ref _inProgress, value);
		}

		[Ordinal(1)] 
		[RED("sceneFile")] 
		public raRef<scnSceneResource> SceneFile
		{
			get => GetProperty(ref _sceneFile);
			set => SetProperty(ref _sceneFile, value);
		}

		[Ordinal(2)] 
		[RED("SceneVersion")] 
		public CEnum<scnSceneVersionCheck> SceneVersion
		{
			get => GetProperty(ref _sceneVersion);
			set => SetProperty(ref _sceneVersion, value);
		}

		public scnBraindanceJumpInProgress_ConditionType(IRed4EngineFile cr2w, CVariable parent, string name) : base(cr2w, parent, name) { }
	}
}
