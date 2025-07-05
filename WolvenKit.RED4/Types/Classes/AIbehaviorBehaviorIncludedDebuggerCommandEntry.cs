using static WolvenKit.RED4.Types.Enums;

namespace WolvenKit.RED4.Types
{
	public partial class AIbehaviorBehaviorIncludedDebuggerCommandEntry : RedBaseClass
	{
		[Ordinal(0)] 
		[RED("nodeId")] 
		public CGuid NodeId
		{
			get => GetPropertyValue<CGuid>();
			set => SetPropertyValue<CGuid>(value);
		}

		[Ordinal(1)] 
		[RED("includedBehaviorResourcePath")] 
		public CString IncludedBehaviorResourcePath
		{
			get => GetPropertyValue<CString>();
			set => SetPropertyValue<CString>(value);
		}

		public AIbehaviorBehaviorIncludedDebuggerCommandEntry()
		{
			PostConstruct();
		}

		partial void PostConstruct();
	}
}
