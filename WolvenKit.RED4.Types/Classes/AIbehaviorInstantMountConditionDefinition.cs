using static WolvenKit.RED4.Types.Enums;

namespace WolvenKit.RED4.Types
{
	[REDMeta]
	public partial class AIbehaviorInstantMountConditionDefinition : AIbehaviorConditionDefinition
	{
		[Ordinal(1)] 
		[RED("mountData")] 
		public CHandle<AIArgumentMapping> MountData
		{
			get => GetPropertyValue<CHandle<AIArgumentMapping>>();
			set => SetPropertyValue<CHandle<AIArgumentMapping>>(value);
		}
	}
}
