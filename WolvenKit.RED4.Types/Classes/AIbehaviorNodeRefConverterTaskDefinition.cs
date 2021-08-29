using static WolvenKit.RED4.Types.Enums;

namespace WolvenKit.RED4.Types
{
	[REDMeta]
	public partial class AIbehaviorNodeRefConverterTaskDefinition : AIbehaviorTaskDefinition
	{
		private CHandle<AIArgumentMapping> _nodeRef;
		private CHandle<AIArgumentMapping> _result;

		[Ordinal(1)] 
		[RED("nodeRef")] 
		public CHandle<AIArgumentMapping> NodeRef
		{
			get => GetProperty(ref _nodeRef);
			set => SetProperty(ref _nodeRef, value);
		}

		[Ordinal(2)] 
		[RED("result")] 
		public CHandle<AIArgumentMapping> Result
		{
			get => GetProperty(ref _result);
			set => SetProperty(ref _result, value);
		}
	}
}
