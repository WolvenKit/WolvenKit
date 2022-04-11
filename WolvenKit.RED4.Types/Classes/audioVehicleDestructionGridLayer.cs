using static WolvenKit.RED4.Types.Enums;

namespace WolvenKit.RED4.Types
{
	[REDMeta]
	public partial class audioVehicleDestructionGridLayer : RedBaseClass
	{
		[Ordinal(0)] 
		[RED("backLeft")] 
		public audioVehicleDestructionGridCell BackLeft
		{
			get => GetPropertyValue<audioVehicleDestructionGridCell>();
			set => SetPropertyValue<audioVehicleDestructionGridCell>(value);
		}

		[Ordinal(1)] 
		[RED("backRight")] 
		public audioVehicleDestructionGridCell BackRight
		{
			get => GetPropertyValue<audioVehicleDestructionGridCell>();
			set => SetPropertyValue<audioVehicleDestructionGridCell>(value);
		}

		[Ordinal(2)] 
		[RED("centerBackLeft")] 
		public audioVehicleDestructionGridCell CenterBackLeft
		{
			get => GetPropertyValue<audioVehicleDestructionGridCell>();
			set => SetPropertyValue<audioVehicleDestructionGridCell>(value);
		}

		[Ordinal(3)] 
		[RED("centerBackRight")] 
		public audioVehicleDestructionGridCell CenterBackRight
		{
			get => GetPropertyValue<audioVehicleDestructionGridCell>();
			set => SetPropertyValue<audioVehicleDestructionGridCell>(value);
		}

		[Ordinal(4)] 
		[RED("centerForwardLeft")] 
		public audioVehicleDestructionGridCell CenterForwardLeft
		{
			get => GetPropertyValue<audioVehicleDestructionGridCell>();
			set => SetPropertyValue<audioVehicleDestructionGridCell>(value);
		}

		[Ordinal(5)] 
		[RED("centerForwardRight")] 
		public audioVehicleDestructionGridCell CenterForwardRight
		{
			get => GetPropertyValue<audioVehicleDestructionGridCell>();
			set => SetPropertyValue<audioVehicleDestructionGridCell>(value);
		}

		[Ordinal(6)] 
		[RED("frontLeft")] 
		public audioVehicleDestructionGridCell FrontLeft
		{
			get => GetPropertyValue<audioVehicleDestructionGridCell>();
			set => SetPropertyValue<audioVehicleDestructionGridCell>(value);
		}

		[Ordinal(7)] 
		[RED("frontRight")] 
		public audioVehicleDestructionGridCell FrontRight
		{
			get => GetPropertyValue<audioVehicleDestructionGridCell>();
			set => SetPropertyValue<audioVehicleDestructionGridCell>(value);
		}

		public audioVehicleDestructionGridLayer()
		{
			BackLeft = new();
			BackRight = new();
			CenterBackLeft = new();
			CenterBackRight = new();
			CenterForwardLeft = new();
			CenterForwardRight = new();
			FrontLeft = new();
			FrontRight = new();
		}
	}
}
