using static WolvenKit.RED4.Types.Enums;

namespace WolvenKit.RED4.Types
{
	[REDMeta]
	public partial class gameEffectDebugSettings : RedBaseClass
	{
		private CBool _overrideGlobalSettings;
		private CFloat _duration;
		private CColor _color;

		[Ordinal(0)] 
		[RED("overrideGlobalSettings")] 
		public CBool OverrideGlobalSettings
		{
			get => GetProperty(ref _overrideGlobalSettings);
			set => SetProperty(ref _overrideGlobalSettings, value);
		}

		[Ordinal(1)] 
		[RED("duration")] 
		public CFloat Duration
		{
			get => GetProperty(ref _duration);
			set => SetProperty(ref _duration, value);
		}

		[Ordinal(2)] 
		[RED("color")] 
		public CColor Color
		{
			get => GetProperty(ref _color);
			set => SetProperty(ref _color, value);
		}
	}
}
