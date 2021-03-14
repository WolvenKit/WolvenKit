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
			get
			{
				if (_globalEntityRef == null)
				{
					_globalEntityRef = (gameEntityReference) CR2WTypeManager.Create("gameEntityReference", "GlobalEntityRef", cr2w, this);
				}
				return _globalEntityRef;
			}
			set
			{
				if (_globalEntityRef == value)
				{
					return;
				}
				_globalEntityRef = value;
				PropertySet(this);
			}
		}

		[Ordinal(1)] 
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

		[Ordinal(2)] 
		[RED("SectionName")] 
		public CName SectionName
		{
			get
			{
				if (_sectionName == null)
				{
					_sectionName = (CName) CR2WTypeManager.Create("CName", "SectionName", cr2w, this);
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

		[Ordinal(3)] 
		[RED("ActorName")] 
		public CString ActorName
		{
			get
			{
				if (_actorName == null)
				{
					_actorName = (CString) CR2WTypeManager.Create("String", "ActorName", cr2w, this);
				}
				return _actorName;
			}
			set
			{
				if (_actorName == value)
				{
					return;
				}
				_actorName = value;
				PropertySet(this);
			}
		}

		[Ordinal(4)] 
		[RED("isInverted")] 
		public CBool IsInverted
		{
			get
			{
				if (_isInverted == null)
				{
					_isInverted = (CBool) CR2WTypeManager.Create("Bool", "isInverted", cr2w, this);
				}
				return _isInverted;
			}
			set
			{
				if (_isInverted == value)
				{
					return;
				}
				_isInverted = value;
				PropertySet(this);
			}
		}

		public questSceneTalking_ConditionType(CR2WFile cr2w, CVariable parent, string name) : base(cr2w, parent, name) { }
	}
}
