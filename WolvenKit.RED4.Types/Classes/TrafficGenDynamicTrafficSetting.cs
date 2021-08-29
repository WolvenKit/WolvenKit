using static WolvenKit.RED4.Types.Enums;

namespace WolvenKit.RED4.Types
{
	[REDMeta]
	public partial class TrafficGenDynamicTrafficSetting : RedBaseClass
	{
		private CEnum<TrafficGenDynamicImpact> _impact;

		[Ordinal(0)] 
		[RED("impact")] 
		public CEnum<TrafficGenDynamicImpact> Impact
		{
			get => GetProperty(ref _impact);
			set => SetProperty(ref _impact, value);
		}
	}
}
