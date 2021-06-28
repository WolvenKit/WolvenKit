using WolvenKit.RED4.CR2W.Reflection;
using FastMember;
using static WolvenKit.RED4.CR2W.Types.Enums;

namespace WolvenKit.RED4.CR2W.Types
{
	[REDMeta]
	public class AIbehaviorBehaviorIncludedDebuggerCommandEntry : CVariable
	{
		private CGUID _nodeId;
		private CString _includedBehaviorResourcePath;

		[Ordinal(0)] 
		[RED("nodeId")] 
		public CGUID NodeId
		{
			get => GetProperty(ref _nodeId);
			set => SetProperty(ref _nodeId, value);
		}

		[Ordinal(1)] 
		[RED("includedBehaviorResourcePath")] 
		public CString IncludedBehaviorResourcePath
		{
			get => GetProperty(ref _includedBehaviorResourcePath);
			set => SetProperty(ref _includedBehaviorResourcePath, value);
		}

		public AIbehaviorBehaviorIncludedDebuggerCommandEntry(IRed4EngineFile cr2w, CVariable parent, string name) : base(cr2w, parent, name) { }
	}
}
