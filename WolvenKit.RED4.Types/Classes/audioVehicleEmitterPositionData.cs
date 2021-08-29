using static WolvenKit.RED4.Types.Enums;

namespace WolvenKit.RED4.Types
{
	[REDMeta]
	public partial class audioVehicleEmitterPositionData : RedBaseClass
	{
		private Vector3 _engineEmitterPosition;
		private Vector3 _exaustEmitterPosition;
		private Vector3 _centralEmitterPosition;
		private Vector3 _hoodEmitterPosition;
		private Vector3 _trunkEmitterPosition;
		private Vector3 _wheel1Position;
		private Vector3 _wheel2Position;
		private Vector3 _wheel3Position;
		private Vector3 _wheel4Position;

		[Ordinal(0)] 
		[RED("engineEmitterPosition")] 
		public Vector3 EngineEmitterPosition
		{
			get => GetProperty(ref _engineEmitterPosition);
			set => SetProperty(ref _engineEmitterPosition, value);
		}

		[Ordinal(1)] 
		[RED("exaustEmitterPosition")] 
		public Vector3 ExaustEmitterPosition
		{
			get => GetProperty(ref _exaustEmitterPosition);
			set => SetProperty(ref _exaustEmitterPosition, value);
		}

		[Ordinal(2)] 
		[RED("centralEmitterPosition")] 
		public Vector3 CentralEmitterPosition
		{
			get => GetProperty(ref _centralEmitterPosition);
			set => SetProperty(ref _centralEmitterPosition, value);
		}

		[Ordinal(3)] 
		[RED("hoodEmitterPosition")] 
		public Vector3 HoodEmitterPosition
		{
			get => GetProperty(ref _hoodEmitterPosition);
			set => SetProperty(ref _hoodEmitterPosition, value);
		}

		[Ordinal(4)] 
		[RED("trunkEmitterPosition")] 
		public Vector3 TrunkEmitterPosition
		{
			get => GetProperty(ref _trunkEmitterPosition);
			set => SetProperty(ref _trunkEmitterPosition, value);
		}

		[Ordinal(5)] 
		[RED("wheel1Position")] 
		public Vector3 Wheel1Position
		{
			get => GetProperty(ref _wheel1Position);
			set => SetProperty(ref _wheel1Position, value);
		}

		[Ordinal(6)] 
		[RED("wheel2Position")] 
		public Vector3 Wheel2Position
		{
			get => GetProperty(ref _wheel2Position);
			set => SetProperty(ref _wheel2Position, value);
		}

		[Ordinal(7)] 
		[RED("wheel3Position")] 
		public Vector3 Wheel3Position
		{
			get => GetProperty(ref _wheel3Position);
			set => SetProperty(ref _wheel3Position, value);
		}

		[Ordinal(8)] 
		[RED("wheel4Position")] 
		public Vector3 Wheel4Position
		{
			get => GetProperty(ref _wheel4Position);
			set => SetProperty(ref _wheel4Position, value);
		}
	}
}
