using WolvenKit.RED4.CR2W.Reflection;
using FastMember;
using static WolvenKit.RED4.CR2W.Types.Enums;

namespace WolvenKit.RED4.CR2W.Types
{
	[REDMeta]
	public class AIbehaviorAgentInfoDebuggerCommandEntry : CVariable
	{
		private AIbehaviorBehaviorInstanceCallStack _callStack;
		private CString _behaviorResourcePath;

		[Ordinal(0)] 
		[RED("callStack")] 
		public AIbehaviorBehaviorInstanceCallStack CallStack
		{
			get => GetProperty(ref _callStack);
			set => SetProperty(ref _callStack, value);
		}

		[Ordinal(1)] 
		[RED("behaviorResourcePath")] 
		public CString BehaviorResourcePath
		{
			get => GetProperty(ref _behaviorResourcePath);
			set => SetProperty(ref _behaviorResourcePath, value);
		}

		public AIbehaviorAgentInfoDebuggerCommandEntry(IRed4EngineFile cr2w, CVariable parent, string name) : base(cr2w, parent, name) { }
	}
}
