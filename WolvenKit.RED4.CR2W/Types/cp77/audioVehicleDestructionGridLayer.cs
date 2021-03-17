using WolvenKit.RED4.CR2W.Reflection;
using FastMember;
using static WolvenKit.RED4.CR2W.Types.Enums;

namespace WolvenKit.RED4.CR2W.Types
{
	[REDMeta]
	public class audioVehicleDestructionGridLayer : CVariable
	{
		private audioVehicleDestructionGridCell _backLeft;
		private audioVehicleDestructionGridCell _backRight;
		private audioVehicleDestructionGridCell _centerBackLeft;
		private audioVehicleDestructionGridCell _centerBackRight;
		private audioVehicleDestructionGridCell _centerForwardLeft;
		private audioVehicleDestructionGridCell _centerForwardRight;
		private audioVehicleDestructionGridCell _frontLeft;
		private audioVehicleDestructionGridCell _frontRight;

		[Ordinal(0)] 
		[RED("backLeft")] 
		public audioVehicleDestructionGridCell BackLeft
		{
			get => GetProperty(ref _backLeft);
			set => SetProperty(ref _backLeft, value);
		}

		[Ordinal(1)] 
		[RED("backRight")] 
		public audioVehicleDestructionGridCell BackRight
		{
			get => GetProperty(ref _backRight);
			set => SetProperty(ref _backRight, value);
		}

		[Ordinal(2)] 
		[RED("centerBackLeft")] 
		public audioVehicleDestructionGridCell CenterBackLeft
		{
			get => GetProperty(ref _centerBackLeft);
			set => SetProperty(ref _centerBackLeft, value);
		}

		[Ordinal(3)] 
		[RED("centerBackRight")] 
		public audioVehicleDestructionGridCell CenterBackRight
		{
			get => GetProperty(ref _centerBackRight);
			set => SetProperty(ref _centerBackRight, value);
		}

		[Ordinal(4)] 
		[RED("centerForwardLeft")] 
		public audioVehicleDestructionGridCell CenterForwardLeft
		{
			get => GetProperty(ref _centerForwardLeft);
			set => SetProperty(ref _centerForwardLeft, value);
		}

		[Ordinal(5)] 
		[RED("centerForwardRight")] 
		public audioVehicleDestructionGridCell CenterForwardRight
		{
			get => GetProperty(ref _centerForwardRight);
			set => SetProperty(ref _centerForwardRight, value);
		}

		[Ordinal(6)] 
		[RED("frontLeft")] 
		public audioVehicleDestructionGridCell FrontLeft
		{
			get => GetProperty(ref _frontLeft);
			set => SetProperty(ref _frontLeft, value);
		}

		[Ordinal(7)] 
		[RED("frontRight")] 
		public audioVehicleDestructionGridCell FrontRight
		{
			get => GetProperty(ref _frontRight);
			set => SetProperty(ref _frontRight, value);
		}

		public audioVehicleDestructionGridLayer(CR2WFile cr2w, CVariable parent, string name) : base(cr2w, parent, name) { }
	}
}
