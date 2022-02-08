using static WolvenKit.RED4.Types.Enums;

namespace WolvenKit.RED4.Types
{
	[REDMeta]
	public partial class AnimFeature_TriggerModeChange : animAnimFeature
	{
		[Ordinal(0)] 
		[RED("cycleTime")] 
		public CFloat CycleTime
		{
			get => GetPropertyValue<CFloat>();
			set => SetPropertyValue<CFloat>(value);
		}
	}
}
