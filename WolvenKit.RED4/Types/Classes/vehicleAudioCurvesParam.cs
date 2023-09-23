using static WolvenKit.RED4.Types.Enums;

namespace WolvenKit.RED4.Types
{
	public partial class vehicleAudioCurvesParam : IScriptable
	{
		[Ordinal(0)] 
		[RED("audioCurves")] 
		public CResourceReference<vehicleAudioVehicleCurveSet> AudioCurves
		{
			get => GetPropertyValue<CResourceReference<vehicleAudioVehicleCurveSet>>();
			set => SetPropertyValue<CResourceReference<vehicleAudioVehicleCurveSet>>(value);
		}

		public vehicleAudioCurvesParam()
		{
			PostConstruct();
		}

		partial void PostConstruct();
	}
}
