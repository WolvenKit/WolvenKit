using WolvenKit.RED4.CR2W.Reflection;
using FastMember;
using static WolvenKit.RED4.CR2W.Types.Enums;

namespace WolvenKit.RED4.CR2W.Types
{
	[REDMeta]
	public class gameuiBaseMenuGameControllerPuppetSceneInfo : CVariable
	{
		private CName _sceneName;
		private NodeRef _markerRef;
		private NodeRef _prefabRef;
		private raRef<entEntityTemplate> _entityTemplate;
		private TweakDBID _puppetRecordId;
		private CEnum<gameuiBaseMenuGameControllerPuppetGenderInfo> _gender;

		[Ordinal(0)] 
		[RED("sceneName")] 
		public CName SceneName
		{
			get
			{
				if (_sceneName == null)
				{
					_sceneName = (CName) CR2WTypeManager.Create("CName", "sceneName", cr2w, this);
				}
				return _sceneName;
			}
			set
			{
				if (_sceneName == value)
				{
					return;
				}
				_sceneName = value;
				PropertySet(this);
			}
		}

		[Ordinal(1)] 
		[RED("markerRef")] 
		public NodeRef MarkerRef
		{
			get
			{
				if (_markerRef == null)
				{
					_markerRef = (NodeRef) CR2WTypeManager.Create("NodeRef", "markerRef", cr2w, this);
				}
				return _markerRef;
			}
			set
			{
				if (_markerRef == value)
				{
					return;
				}
				_markerRef = value;
				PropertySet(this);
			}
		}

		[Ordinal(2)] 
		[RED("prefabRef")] 
		public NodeRef PrefabRef
		{
			get
			{
				if (_prefabRef == null)
				{
					_prefabRef = (NodeRef) CR2WTypeManager.Create("NodeRef", "prefabRef", cr2w, this);
				}
				return _prefabRef;
			}
			set
			{
				if (_prefabRef == value)
				{
					return;
				}
				_prefabRef = value;
				PropertySet(this);
			}
		}

		[Ordinal(3)] 
		[RED("entityTemplate")] 
		public raRef<entEntityTemplate> EntityTemplate
		{
			get
			{
				if (_entityTemplate == null)
				{
					_entityTemplate = (raRef<entEntityTemplate>) CR2WTypeManager.Create("raRef:entEntityTemplate", "entityTemplate", cr2w, this);
				}
				return _entityTemplate;
			}
			set
			{
				if (_entityTemplate == value)
				{
					return;
				}
				_entityTemplate = value;
				PropertySet(this);
			}
		}

		[Ordinal(4)] 
		[RED("puppetRecordId")] 
		public TweakDBID PuppetRecordId
		{
			get
			{
				if (_puppetRecordId == null)
				{
					_puppetRecordId = (TweakDBID) CR2WTypeManager.Create("TweakDBID", "puppetRecordId", cr2w, this);
				}
				return _puppetRecordId;
			}
			set
			{
				if (_puppetRecordId == value)
				{
					return;
				}
				_puppetRecordId = value;
				PropertySet(this);
			}
		}

		[Ordinal(5)] 
		[RED("gender")] 
		public CEnum<gameuiBaseMenuGameControllerPuppetGenderInfo> Gender
		{
			get
			{
				if (_gender == null)
				{
					_gender = (CEnum<gameuiBaseMenuGameControllerPuppetGenderInfo>) CR2WTypeManager.Create("gameuiBaseMenuGameControllerPuppetGenderInfo", "gender", cr2w, this);
				}
				return _gender;
			}
			set
			{
				if (_gender == value)
				{
					return;
				}
				_gender = value;
				PropertySet(this);
			}
		}

		public gameuiBaseMenuGameControllerPuppetSceneInfo(CR2WFile cr2w, CVariable parent, string name) : base(cr2w, parent, name) { }
	}
}
