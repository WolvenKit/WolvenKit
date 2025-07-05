using static WolvenKit.RED4.Types.Enums;

namespace WolvenKit.RED4.Types
{
	public partial class audioVehicleEmitterPositionData : RedBaseClass
	{
		[Ordinal(0)] 
		[RED("engineEmitterPosition")] 
		public Vector3 EngineEmitterPosition
		{
			get => GetPropertyValue<Vector3>();
			set => SetPropertyValue<Vector3>(value);
		}

		[Ordinal(1)] 
		[RED("exaustEmitterPosition")] 
		public Vector3 ExaustEmitterPosition
		{
			get => GetPropertyValue<Vector3>();
			set => SetPropertyValue<Vector3>(value);
		}

		[Ordinal(2)] 
		[RED("centralEmitterPosition")] 
		public Vector3 CentralEmitterPosition
		{
			get => GetPropertyValue<Vector3>();
			set => SetPropertyValue<Vector3>(value);
		}

		[Ordinal(3)] 
		[RED("hoodEmitterPosition")] 
		public Vector3 HoodEmitterPosition
		{
			get => GetPropertyValue<Vector3>();
			set => SetPropertyValue<Vector3>(value);
		}

		[Ordinal(4)] 
		[RED("trunkEmitterPosition")] 
		public Vector3 TrunkEmitterPosition
		{
			get => GetPropertyValue<Vector3>();
			set => SetPropertyValue<Vector3>(value);
		}

		[Ordinal(5)] 
		[RED("wheel1Position")] 
		public Vector3 Wheel1Position
		{
			get => GetPropertyValue<Vector3>();
			set => SetPropertyValue<Vector3>(value);
		}

		[Ordinal(6)] 
		[RED("wheel2Position")] 
		public Vector3 Wheel2Position
		{
			get => GetPropertyValue<Vector3>();
			set => SetPropertyValue<Vector3>(value);
		}

		[Ordinal(7)] 
		[RED("wheel3Position")] 
		public Vector3 Wheel3Position
		{
			get => GetPropertyValue<Vector3>();
			set => SetPropertyValue<Vector3>(value);
		}

		[Ordinal(8)] 
		[RED("wheel4Position")] 
		public Vector3 Wheel4Position
		{
			get => GetPropertyValue<Vector3>();
			set => SetPropertyValue<Vector3>(value);
		}

		public audioVehicleEmitterPositionData()
		{
			EngineEmitterPosition = new Vector3();
			ExaustEmitterPosition = new Vector3();
			CentralEmitterPosition = new Vector3();
			HoodEmitterPosition = new Vector3();
			TrunkEmitterPosition = new Vector3();
			Wheel1Position = new Vector3();
			Wheel2Position = new Vector3();
			Wheel3Position = new Vector3();
			Wheel4Position = new Vector3();

			PostConstruct();
		}

		partial void PostConstruct();
	}
}
