using static WolvenKit.RED4.Types.Enums;

namespace WolvenKit.RED4.Types
{
	public partial class GlitchedTurret : Device
	{
		[Ordinal(88)] 
		[RED("animFeature")] 
		public CHandle<AnimFeature_SensorDevice> AnimFeature
		{
			get => GetPropertyValue<CHandle<AnimFeature_SensorDevice>>();
			set => SetPropertyValue<CHandle<AnimFeature_SensorDevice>>(value);
		}

		public GlitchedTurret()
		{
			ControllerTypeName = "GlitchedTurretController";

			PostConstruct();
		}

		partial void PostConstruct();
	}
}
