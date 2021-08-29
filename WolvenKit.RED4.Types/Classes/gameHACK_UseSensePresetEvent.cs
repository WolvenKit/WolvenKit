using static WolvenKit.RED4.Types.Enums;

namespace WolvenKit.RED4.Types
{
	[REDMeta]
	public partial class gameHACK_UseSensePresetEvent : redEvent
	{
		private TweakDBID _sensePreset;

		[Ordinal(0)] 
		[RED("sensePreset")] 
		public TweakDBID SensePreset
		{
			get => GetProperty(ref _sensePreset);
			set => SetProperty(ref _sensePreset, value);
		}
	}
}
