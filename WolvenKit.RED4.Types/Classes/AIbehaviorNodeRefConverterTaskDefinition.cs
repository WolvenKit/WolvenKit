using static WolvenKit.RED4.Types.Enums;

namespace WolvenKit.RED4.Types
{
	[REDMeta]
	public partial class AIbehaviorNodeRefConverterTaskDefinition : AIbehaviorTaskDefinition
	{
		[Ordinal(1)] 
		[RED("nodeRef")] 
		public CHandle<AIArgumentMapping> NodeRef
		{
			get => GetPropertyValue<CHandle<AIArgumentMapping>>();
			set => SetPropertyValue<CHandle<AIArgumentMapping>>(value);
		}

		[Ordinal(2)] 
		[RED("result")] 
		public CHandle<AIArgumentMapping> Result
		{
			get => GetPropertyValue<CHandle<AIArgumentMapping>>();
			set => SetPropertyValue<CHandle<AIArgumentMapping>>(value);
		}
	}
}
