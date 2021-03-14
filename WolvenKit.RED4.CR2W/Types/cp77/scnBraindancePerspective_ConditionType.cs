using WolvenKit.RED4.CR2W.Reflection;
using FastMember;
using static WolvenKit.RED4.CR2W.Types.Enums;

namespace WolvenKit.RED4.CR2W.Types
{
	[REDMeta]
	public class scnBraindancePerspective_ConditionType : scnIBraindanceConditionType
	{
		private CEnum<scnBraindancePerspective> _perspective;
		private raRef<scnSceneResource> _sceneFile;

		[Ordinal(0)] 
		[RED("perspective")] 
		public CEnum<scnBraindancePerspective> Perspective
		{
			get
			{
				if (_perspective == null)
				{
					_perspective = (CEnum<scnBraindancePerspective>) CR2WTypeManager.Create("scnBraindancePerspective", "perspective", cr2w, this);
				}
				return _perspective;
			}
			set
			{
				if (_perspective == value)
				{
					return;
				}
				_perspective = value;
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

		public scnBraindancePerspective_ConditionType(CR2WFile cr2w, CVariable parent, string name) : base(cr2w, parent, name) { }
	}
}
