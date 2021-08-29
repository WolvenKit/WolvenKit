using static WolvenKit.RED4.Types.Enums;

namespace WolvenKit.RED4.Types
{
	[REDMeta]
	public partial class AIbehaviorBehaviorIncludedDebuggerCommandEntry : RedBaseClass
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
	}
}
