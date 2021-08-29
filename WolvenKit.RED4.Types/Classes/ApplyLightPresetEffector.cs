using static WolvenKit.RED4.Types.Enums;

namespace WolvenKit.RED4.Types
{
	[REDMeta]
	public partial class ApplyLightPresetEffector : gameEffector
	{
		private CWeakHandle<gamedataLightPreset_Record> _lightPreset;

		[Ordinal(0)] 
		[RED("lightPreset")] 
		public CWeakHandle<gamedataLightPreset_Record> LightPreset
		{
			get => GetProperty(ref _lightPreset);
			set => SetProperty(ref _lightPreset, value);
		}
	}
}
