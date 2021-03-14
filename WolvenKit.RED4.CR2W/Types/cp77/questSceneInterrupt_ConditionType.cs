using WolvenKit.RED4.CR2W.Reflection;
using FastMember;
using static WolvenKit.RED4.CR2W.Types.Enums;

namespace WolvenKit.RED4.CR2W.Types
{
	[REDMeta]
	public class questSceneInterrupt_ConditionType : questISceneConditionType
	{
		private raRef<scnSceneResource> _sceneFile;
		private CBool _onlyInSafeMoment;
		private CArray<CHandle<scnIInterruptCondition>> _interruptConditions;

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
		[RED("onlyInSafeMoment")] 
		public CBool OnlyInSafeMoment
		{
			get
			{
				if (_onlyInSafeMoment == null)
				{
					_onlyInSafeMoment = (CBool) CR2WTypeManager.Create("Bool", "onlyInSafeMoment", cr2w, this);
				}
				return _onlyInSafeMoment;
			}
			set
			{
				if (_onlyInSafeMoment == value)
				{
					return;
				}
				_onlyInSafeMoment = value;
				PropertySet(this);
			}
		}

		[Ordinal(2)] 
		[RED("interruptConditions")] 
		public CArray<CHandle<scnIInterruptCondition>> InterruptConditions
		{
			get
			{
				if (_interruptConditions == null)
				{
					_interruptConditions = (CArray<CHandle<scnIInterruptCondition>>) CR2WTypeManager.Create("array:handle:scnIInterruptCondition", "interruptConditions", cr2w, this);
				}
				return _interruptConditions;
			}
			set
			{
				if (_interruptConditions == value)
				{
					return;
				}
				_interruptConditions = value;
				PropertySet(this);
			}
		}

		public questSceneInterrupt_ConditionType(CR2WFile cr2w, CVariable parent, string name) : base(cr2w, parent, name) { }
	}
}
