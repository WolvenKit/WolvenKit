using static WolvenKit.RED4.Types.Enums;

namespace WolvenKit.RED4.Types
{
	[REDMeta]
	public partial class TrafficGenDynamicTrafficSetting : RedBaseClass
	{
		[Ordinal(0)] 
		[RED("impact")] 
		public CEnum<TrafficGenDynamicImpact> Impact
		{
			get => GetPropertyValue<CEnum<TrafficGenDynamicImpact>>();
			set => SetPropertyValue<CEnum<TrafficGenDynamicImpact>>(value);
		}
	}
}
