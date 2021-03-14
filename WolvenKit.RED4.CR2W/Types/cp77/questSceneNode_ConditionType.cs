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
		[RED("inputName")] 
		public CName InputName
		{
			get
			{
				if (_inputName == null)
				{
					_inputName = (CName) CR2WTypeManager.Create("CName", "inputName", cr2w, this);
				}
				return _inputName;
			}
			set
			{
				if (_inputName == value)
				{
					return;
				}
				_inputName = value;
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

		public questSceneNode_ConditionType(CR2WFile cr2w, CVariable parent, string name) : base(cr2w, parent, name) { }
	}
}
