using static WolvenKit.RED4.Types.Enums;

namespace WolvenKit.RED4.Types
{
	public partial class ApplyLightPresetEffector : gameEffector
	{
		[Ordinal(0)] 
		[RED("lightPreset")] 
		public CWeakHandle<gamedataLightPreset_Record> LightPreset
		{
			get => GetPropertyValue<CWeakHandle<gamedataLightPreset_Record>>();
			set => SetPropertyValue<CWeakHandle<gamedataLightPreset_Record>>(value);
		}

		public ApplyLightPresetEffector()
		{
			PostConstruct();
		}

		partial void PostConstruct();
	}
}
