using WolvenKit.RED4.CR2W.Reflection;
using FastMember;
using static WolvenKit.RED4.CR2W.Types.Enums;

namespace WolvenKit.RED4.CR2W.Types
{
	[REDMeta]
	public class questEntityManagerSetDestructionState_NodeType : questIEntityManager_NodeType
	{
		private CEnum<questSetDestructionStateAction> _action;
		private CArray<questEntityManagerSetDestructionState_NodeTypeParams> _params;

		[Ordinal(0)] 
		[RED("action")] 
		public CEnum<questSetDestructionStateAction> Action
		{
			get
			{
				if (_action == null)
				{
					_action = (CEnum<questSetDestructionStateAction>) CR2WTypeManager.Create("questSetDestructionStateAction", "action", cr2w, this);
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
		[RED("params")] 
		public CArray<questEntityManagerSetDestructionState_NodeTypeParams> Params
		{
			get
			{
				if (_params == null)
				{
					_params = (CArray<questEntityManagerSetDestructionState_NodeTypeParams>) CR2WTypeManager.Create("array:questEntityManagerSetDestructionState_NodeTypeParams", "params", cr2w, this);
				}
				return _params;
			}
			set
			{
				if (_params == value)
				{
					return;
				}
				_params = value;
				PropertySet(this);
			}
		}

		public questEntityManagerSetDestructionState_NodeType(CR2WFile cr2w, CVariable parent, string name) : base(cr2w, parent, name) { }
	}
}
