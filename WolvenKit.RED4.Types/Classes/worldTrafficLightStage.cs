using static WolvenKit.RED4.Types.Enums;

namespace WolvenKit.RED4.Types
{
	[REDMeta]
	public partial class worldTrafficLightStage : RedBaseClass
	{
		private CEnum<worldTrafficLightColor> _color;
		private CFloat _duration;

		[Ordinal(0)] 
		[RED("color")] 
		public CEnum<worldTrafficLightColor> Color
		{
			get => GetProperty(ref _color);
			set => SetProperty(ref _color, value);
		}

		[Ordinal(1)] 
		[RED("duration")] 
		public CFloat Duration
		{
			get => GetProperty(ref _duration);
			set => SetProperty(ref _duration, value);
		}
	}
}
