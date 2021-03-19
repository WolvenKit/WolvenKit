using WolvenKit.RED4.CR2W.Reflection;
using FastMember;
using static WolvenKit.RED4.CR2W.Types.Enums;

namespace WolvenKit.RED4.CR2W.Types
{
	[REDMeta]
	public class questSceneTalking_ConditionType : questISceneConditionType
	{
		private gameEntityReference _globalEntityRef;
		private raRef<scnSceneResource> _sceneFile;
		private CName _sectionName;
		private CString _actorName;
		private CBool _isInverted;

		[Ordinal(0)] 
		[RED("GlobalEntityRef")] 
		public gameEntityReference GlobalEntityRef
		{
			get => GetProperty(ref _globalEntityRef);
			set => SetProperty(ref _globalEntityRef, value);
		}

		[Ordinal(1)] 
		[RED("sceneFile")] 
		public raRef<scnSceneResource> SceneFile
		{
			get => GetProperty(ref _sceneFile);
			set => SetProperty(ref _sceneFile, value);
		}

		[Ordinal(2)] 
		[RED("SectionName")] 
		public CName SectionName
		{
			get => GetProperty(ref _sectionName);
			set => SetProperty(ref _sectionName, value);
		}

		[Ordinal(3)] 
		[RED("ActorName")] 
		public CString ActorName
		{
			get => GetProperty(ref _actorName);
			set => SetProperty(ref _actorName, value);
		}

		[Ordinal(4)] 
		[RED("isInverted")] 
		public CBool IsInverted
		{
			get => GetProperty(ref _isInverted);
			set => SetProperty(ref _isInverted, value);
		}

		public questSceneTalking_ConditionType(CR2WFile cr2w, CVariable parent, string name) : base(cr2w, parent, name) { }
	}
}
