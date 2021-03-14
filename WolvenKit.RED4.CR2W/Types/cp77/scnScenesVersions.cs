using WolvenKit.RED4.CR2W.Reflection;
using FastMember;
using static WolvenKit.RED4.CR2W.Types.Enums;

namespace WolvenKit.RED4.CR2W.Types
{
	[REDMeta]
	public class scnScenesVersions : CResource
	{
		private CUInt32 _currentVersion;
		private CArray<scnScenesVersionsSceneChanges> _scenesChanges;

		[Ordinal(1)] 
		[RED("currentVersion")] 
		public CUInt32 CurrentVersion
		{
			get
			{
				if (_currentVersion == null)
				{
					_currentVersion = (CUInt32) CR2WTypeManager.Create("Uint32", "currentVersion", cr2w, this);
				}
				return _currentVersion;
			}
			set
			{
				if (_currentVersion == value)
				{
					return;
				}
				_currentVersion = value;
				PropertySet(this);
			}
		}

		[Ordinal(2)] 
		[RED("scenesChanges")] 
		public CArray<scnScenesVersionsSceneChanges> ScenesChanges
		{
			get
			{
				if (_scenesChanges == null)
				{
					_scenesChanges = (CArray<scnScenesVersionsSceneChanges>) CR2WTypeManager.Create("array:scnScenesVersionsSceneChanges", "scenesChanges", cr2w, this);
				}
				return _scenesChanges;
			}
			set
			{
				if (_scenesChanges == value)
				{
					return;
				}
				_scenesChanges = value;
				PropertySet(this);
			}
		}

		public scnScenesVersions(CR2WFile cr2w, CVariable parent, string name) : base(cr2w, parent, name) { }
	}
}
