using WolvenKit.RED4.CR2W.Reflection;
using FastMember;
using static WolvenKit.RED4.CR2W.Types.Enums;

namespace WolvenKit.RED4.CR2W.Types
{
	[REDMeta]
	public class scnScenesVersionsChangedRecord : CVariable
	{
		private CUInt32 _changeInVersion;
		private raRef<scnSceneResource> _sceneBeforeChange;

		[Ordinal(0)] 
		[RED("changeInVersion")] 
		public CUInt32 ChangeInVersion
		{
			get
			{
				if (_changeInVersion == null)
				{
					_changeInVersion = (CUInt32) CR2WTypeManager.Create("Uint32", "changeInVersion", cr2w, this);
				}
				return _changeInVersion;
			}
			set
			{
				if (_changeInVersion == value)
				{
					return;
				}
				_changeInVersion = value;
				PropertySet(this);
			}
		}

		[Ordinal(1)] 
		[RED("sceneBeforeChange")] 
		public raRef<scnSceneResource> SceneBeforeChange
		{
			get
			{
				if (_sceneBeforeChange == null)
				{
					_sceneBeforeChange = (raRef<scnSceneResource>) CR2WTypeManager.Create("raRef:scnSceneResource", "sceneBeforeChange", cr2w, this);
				}
				return _sceneBeforeChange;
			}
			set
			{
				if (_sceneBeforeChange == value)
				{
					return;
				}
				_sceneBeforeChange = value;
				PropertySet(this);
			}
		}

		public scnScenesVersionsChangedRecord(CR2WFile cr2w, CVariable parent, string name) : base(cr2w, parent, name) { }
	}
}
