using WolvenKit.RED4.CR2W.Reflection;
using FastMember;
using static WolvenKit.RED4.CR2W.Types.Enums;

namespace WolvenKit.RED4.CR2W.Types
{
	[REDMeta]
	public class questDrillingState_ConditionType : questIObjectConditionType
	{
		private NodeRef _objectRef;
		private CEnum<questDrillingState> _state;

		[Ordinal(0)] 
		[RED("objectRef")] 
		public NodeRef ObjectRef
		{
			get => GetProperty(ref _objectRef);
			set => SetProperty(ref _objectRef, value);
		}

		[Ordinal(1)] 
		[RED("state")] 
		public CEnum<questDrillingState> State
		{
			get => GetProperty(ref _state);
			set => SetProperty(ref _state, value);
		}

		public questDrillingState_ConditionType(IRed4EngineFile cr2w, CVariable parent, string name) : base(cr2w, parent, name) { }
	}
}
