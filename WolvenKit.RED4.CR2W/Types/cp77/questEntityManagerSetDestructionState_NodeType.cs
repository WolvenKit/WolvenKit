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
			get => GetProperty(ref _action);
			set => SetProperty(ref _action, value);
		}

		[Ordinal(1)] 
		[RED("params")] 
		public CArray<questEntityManagerSetDestructionState_NodeTypeParams> Params
		{
			get => GetProperty(ref _params);
			set => SetProperty(ref _params, value);
		}

		public questEntityManagerSetDestructionState_NodeType(CR2WFile cr2w, CVariable parent, string name) : base(cr2w, parent, name) { }
	}
}
