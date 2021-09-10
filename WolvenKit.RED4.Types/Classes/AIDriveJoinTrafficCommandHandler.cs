using static WolvenKit.RED4.Types.Enums;

namespace WolvenKit.RED4.Types
{
	[REDMeta]
	public partial class AIDriveJoinTrafficCommandHandler : AICommandHandlerBase
	{
		[Ordinal(1)] 
		[RED("outUseKinematic")] 
		public CHandle<AIArgumentMapping> OutUseKinematic
		{
			get => GetPropertyValue<CHandle<AIArgumentMapping>>();
			set => SetPropertyValue<CHandle<AIArgumentMapping>>(value);
		}

		[Ordinal(2)] 
		[RED("outNeedDriver")] 
		public CHandle<AIArgumentMapping> OutNeedDriver
		{
			get => GetPropertyValue<CHandle<AIArgumentMapping>>();
			set => SetPropertyValue<CHandle<AIArgumentMapping>>(value);
		}
	}
}
