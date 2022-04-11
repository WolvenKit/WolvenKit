using static WolvenKit.RED4.Types.Enums;

namespace WolvenKit.RED4.Types
{
	[REDMeta]
	public partial class ApplyDiodeLightPresetEvent : redEvent
	{
		[Ordinal(0)] 
		[RED("preset")] 
		public DiodeLightPreset Preset
		{
			get => GetPropertyValue<DiodeLightPreset>();
			set => SetPropertyValue<DiodeLightPreset>(value);
		}

		[Ordinal(1)] 
		[RED("delay")] 
		public CFloat Delay
		{
			get => GetPropertyValue<CFloat>();
			set => SetPropertyValue<CFloat>(value);
		}

		[Ordinal(2)] 
		[RED("duration")] 
		public CFloat Duration
		{
			get => GetPropertyValue<CFloat>();
			set => SetPropertyValue<CFloat>(value);
		}

		[Ordinal(3)] 
		[RED("force")] 
		public CBool Force
		{
			get => GetPropertyValue<CBool>();
			set => SetPropertyValue<CBool>(value);
		}

		public ApplyDiodeLightPresetEvent()
		{
			Preset = new() { State = true, ColorMax = new(), ColorMin = new(), OverrideColorMin = true, Strength = 1.000000F };
		}
	}
}
