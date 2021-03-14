using WolvenKit.RED4.CR2W.Reflection;
using FastMember;
using static WolvenKit.RED4.CR2W.Types.Enums;

namespace WolvenKit.RED4.CR2W.Types
{
	[REDMeta]
	public class questCrowdManagerNodeType_ControlCrowd : questICrowdManager_NodeType
	{
		private CEnum<questControlCrowdAction> _action;
		private CName _debugSource;

		[Ordinal(0)] 
		[RED("action")] 
		public CEnum<questControlCrowdAction> Action
		{
			get
			{
				if (_action == null)
				{
					_action = (CEnum<questControlCrowdAction>) CR2WTypeManager.Create("questControlCrowdAction", "action", cr2w, this);
				}
				return _action;
			}
			set
			{
				if (_action == value)
				{
					return;
				}
				_action = value;
				PropertySet(this);
			}
		}

		[Ordinal(1)] 
		[RED("debugSource")] 
		public CName DebugSource
		{
			get
			{
				if (_debugSource == null)
				{
					_debugSource = (CName) CR2WTypeManager.Create("CName", "debugSource", cr2w, this);
				}
				return _debugSource;
			}
			set
			{
				if (_debugSource == value)
				{
					return;
				}
				_debugSource = value;
				PropertySet(this);
			}
		}

		public questCrowdManagerNodeType_ControlCrowd(CR2WFile cr2w, CVariable parent, string name) : base(cr2w, parent, name) { }
	}
}
