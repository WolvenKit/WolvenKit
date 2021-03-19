using WolvenKit.RED4.CR2W.Reflection;
using FastMember;
using static WolvenKit.RED4.CR2W.Types.Enums;

namespace WolvenKit.RED4.CR2W.Types
{
	[REDMeta]
	public class AIbehaviorNodeStatusDebuggerCommandEntry : CVariable
	{
		private CGUID _nodeId;
		private CEnum<AIbehaviorDebugNodeStatus> _status;
		private CUInt32 _generation;
		private CHandle<gamedebugFailure> _failure;

		[Ordinal(0)] 
		[RED("nodeId")] 
		public CGUID NodeId
		{
			get => GetProperty(ref _nodeId);
			set => SetProperty(ref _nodeId, value);
		}

		[Ordinal(1)] 
		[RED("status")] 
		public CEnum<AIbehaviorDebugNodeStatus> Status
		{
			get => GetProperty(ref _status);
			set => SetProperty(ref _status, value);
		}

		[Ordinal(2)] 
		[RED("generation")] 
		public CUInt32 Generation
		{
			get => GetProperty(ref _generation);
			set => SetProperty(ref _generation, value);
		}

		[Ordinal(3)] 
		[RED("failure")] 
		public CHandle<gamedebugFailure> Failure
		{
			get => GetProperty(ref _failure);
			set => SetProperty(ref _failure, value);
		}

		public AIbehaviorNodeStatusDebuggerCommandEntry(CR2WFile cr2w, CVariable parent, string name) : base(cr2w, parent, name) { }
	}
}
