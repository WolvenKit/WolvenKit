using static WolvenKit.RED4.Types.Enums;

namespace WolvenKit.RED4.Types
{
	[REDMeta]
	public partial class CustomValueFromMappingTimeout : AITimeoutCondition
	{
		[Ordinal(1)] 
		[RED("actionTweakIDMapping")] 
		public CHandle<AIArgumentMapping> ActionTweakIDMapping
		{
			get => GetPropertyValue<CHandle<AIArgumentMapping>>();
			set => SetPropertyValue<CHandle<AIArgumentMapping>>(value);
		}
	}
}
