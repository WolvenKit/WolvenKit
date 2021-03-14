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

		[Ordinal(0)] 
		[RED("inProgress")] 
		public CBool InProgress
		{
			get
			{
				if (_inProgress == null)
				{
					_inProgress = (CBool) CR2WTypeManager.Create("Bool", "inProgress", cr2w, this);
				}
				return _inProgress;
			}
			set
			{
				if (_inProgress == value)
				{
					return;
				}
				_inProgress = value;
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

		public scnBraindanceJumpInProgress_ConditionType(CR2WFile cr2w, CVariable parent, string name) : base(cr2w, parent, name) { }
	}
}
