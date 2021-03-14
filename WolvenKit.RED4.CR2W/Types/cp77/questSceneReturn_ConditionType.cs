using WolvenKit.RED4.CR2W.Reflection;
using FastMember;
using static WolvenKit.RED4.CR2W.Types.Enums;

namespace WolvenKit.RED4.CR2W.Types
{
	[REDMeta]
	public class questSceneReturn_ConditionType : questISceneConditionType
	{
		private raRef<scnSceneResource> _sceneFile;
		private CArray<CHandle<scnIReturnCondition>> _returnConditions;

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
		[RED("returnConditions")] 
		public CArray<CHandle<scnIReturnCondition>> ReturnConditions
		{
			get
			{
				if (_returnConditions == null)
				{
					_returnConditions = (CArray<CHandle<scnIReturnCondition>>) CR2WTypeManager.Create("array:handle:scnIReturnCondition", "returnConditions", cr2w, this);
				}
				return _returnConditions;
			}
			set
			{
				if (_returnConditions == value)
				{
					return;
				}
				_returnConditions = value;
				PropertySet(this);
			}
		}

		public questSceneReturn_ConditionType(CR2WFile cr2w, CVariable parent, string name) : base(cr2w, parent, name) { }
	}
}
