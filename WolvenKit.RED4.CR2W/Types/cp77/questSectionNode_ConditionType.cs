using WolvenKit.RED4.CR2W.Reflection;
using FastMember;
using static WolvenKit.RED4.CR2W.Types.Enums;

namespace WolvenKit.RED4.CR2W.Types
{
	[REDMeta]
	public class questSectionNode_ConditionType : questISceneConditionType
	{
		private raRef<scnSceneResource> _sceneFile;
		private CName _sectionName;
		private CEnum<questSceneConditionType> _type;

		[Ordinal(0)] 
		[RED("sceneFile")] 
		public raRef<scnSceneResource> SceneFile
		{
			get
			{
				if (_sceneFile == null)
				{
					_sceneFile = (raRef<scnSceneResource>) CR2WTypeManager.Create("raRef:scnSceneResource", "sceneFile", cr2w, this);
				}
				return _sceneFile;
			}
			set
			{
				if (_sceneFile == value)
				{
					return;
				}
				_sceneFile = value;
				PropertySet(this);
			}
		}

		[Ordinal(1)] 
		[RED("sectionName")] 
		public CName SectionName
		{
			get
			{
				if (_sectionName == null)
				{
					_sectionName = (CName) CR2WTypeManager.Create("CName", "sectionName", cr2w, this);
				}
				return _sectionName;
			}
			set
			{
				if (_sectionName == value)
				{
					return;
				}
				_sectionName = value;
				PropertySet(this);
			}
		}

		[Ordinal(2)] 
		[RED("type")] 
		public CEnum<questSceneConditionType> Type
		{
			get
			{
				if (_type == null)
				{
					_type = (CEnum<questSceneConditionType>) CR2WTypeManager.Create("questSceneConditionType", "type", cr2w, this);
				}
				return _type;
			}
			set
			{
				if (_type == value)
				{
					return;
				}
				_type = value;
				PropertySet(this);
			}
		}

		public questSectionNode_ConditionType(CR2WFile cr2w, CVariable parent, string name) : base(cr2w, parent, name) { }
	}
}
