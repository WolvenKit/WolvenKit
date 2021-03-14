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
			get
			{
				if (_callStack == null)
				{
					_callStack = (AIbehaviorBehaviorInstanceCallStack) CR2WTypeManager.Create("AIbehaviorBehaviorInstanceCallStack", "callStack", cr2w, this);
				}
				return _callStack;
			}
			set
			{
				if (_callStack == value)
				{
					return;
				}
				_callStack = value;
				PropertySet(this);
			}
		}

		[Ordinal(1)] 
		[RED("behaviorResourcePath")] 
		public CString BehaviorResourcePath
		{
			get
			{
				if (_behaviorResourcePath == null)
				{
					_behaviorResourcePath = (CString) CR2WTypeManager.Create("String", "behaviorResourcePath", cr2w, this);
				}
				return _behaviorResourcePath;
			}
			set
			{
				if (_behaviorResourcePath == value)
				{
					return;
				}
				_behaviorResourcePath = value;
				PropertySet(this);
			}
		}

		public AIbehaviorAgentInfoDebuggerCommandEntry(CR2WFile cr2w, CVariable parent, string name) : base(cr2w, parent, name) { }
	}
}
