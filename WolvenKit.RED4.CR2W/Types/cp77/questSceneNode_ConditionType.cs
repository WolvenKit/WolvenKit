using WolvenKit.RED4.CR2W.Reflection;
using FastMember;
using static WolvenKit.RED4.CR2W.Types.Enums;

namespace WolvenKit.RED4.CR2W.Types
{
	[REDMeta]
	public class questSceneNode_ConditionType : questISceneConditionType
	{
		private raRef<scnSceneResource> _sceneFile;
		private CName _inputName;
		private CEnum<questSceneConditionType> _type;

		[Ordinal(0)] 
		[RED("sceneFile")] 
		public raRef<scnSceneResource> SceneFile
		{
			get => GetProperty(ref _sceneFile);
			set => SetProperty(ref _sceneFile, value);
		}

		[Ordinal(1)] 
		[RED("inputName")] 
		public CName InputName
		{
			get => GetProperty(ref _inputName);
			set => SetProperty(ref _inputName, value);
		}

		[Ordinal(2)] 
		[RED("type")] 
		public CEnum<questSceneConditionType> Type
		{
			get => GetProperty(ref _type);
			set => SetProperty(ref _type, value);
		}

		public questSceneNode_ConditionType(CR2WFile cr2w, CVariable parent, string name) : base(cr2w, parent, name) { }
	}
}
