using WolvenKit.RED4.CR2W.Reflection;
using FastMember;
using static WolvenKit.RED4.CR2W.Types.Enums;

namespace WolvenKit.RED4.CR2W.Types
{
	[REDMeta]
	public class scnScenesVersionsSceneChanges : CVariable
	{
		private raRef<scnSceneResource> _scene;
		private CArray<scnScenesVersionsChangedRecord> _sceneChanges;

		[Ordinal(0)] 
		[RED("scene")] 
		public raRef<scnSceneResource> Scene
		{
			get
			{
				if (_scene == null)
				{
					_scene = (raRef<scnSceneResource>) CR2WTypeManager.Create("raRef:scnSceneResource", "scene", cr2w, this);
				}
				return _scene;
			}
			set
			{
				if (_scene == value)
				{
					return;
				}
				_scene = value;
				PropertySet(this);
			}
		}

		[Ordinal(1)] 
		[RED("sceneChanges")] 
		public CArray<scnScenesVersionsChangedRecord> SceneChanges
		{
			get
			{
				if (_sceneChanges == null)
				{
					_sceneChanges = (CArray<scnScenesVersionsChangedRecord>) CR2WTypeManager.Create("array:scnScenesVersionsChangedRecord", "sceneChanges", cr2w, this);
				}
				return _sceneChanges;
			}
			set
			{
				if (_sceneChanges == value)
				{
					return;
				}
				_sceneChanges = value;
				PropertySet(this);
			}
		}

		public scnScenesVersionsSceneChanges(CR2WFile cr2w, CVariable parent, string name) : base(cr2w, parent, name) { }
	}
}
