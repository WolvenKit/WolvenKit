using WolvenKit.RED4.CR2W.Reflection;
using FastMember;
using static WolvenKit.RED4.CR2W.Types.Enums;

namespace WolvenKit.RED4.CR2W.Types
{
	[REDMeta]
	public class scnBraindanceRewinding_ConditionType : scnIBraindanceConditionType
	{
		private CEnum<scnBraindanceSpeed> _speed;
		private raRef<scnSceneResource> _sceneFile;

		[Ordinal(0)] 
		[RED("speed")] 
		public CEnum<scnBraindanceSpeed> Speed
		{
			get
			{
				if (_speed == null)
				{
					_speed = (CEnum<scnBraindanceSpeed>) CR2WTypeManager.Create("scnBraindanceSpeed", "speed", cr2w, this);
				}
				return _speed;
			}
			set
			{
				if (_speed == value)
				{
					return;
				}
				_speed = value;
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

		public scnBraindanceRewinding_ConditionType(CR2WFile cr2w, CVariable parent, string name) : base(cr2w, parent, name) { }
	}
}
