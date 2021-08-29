using static WolvenKit.RED4.Types.Enums;

namespace WolvenKit.RED4.Types
{
	[REDMeta]
	public partial class audioVehicleDoorsSettingsMetadata : RedBaseClass
	{
		private audioVehicleDoorsSettings _door;
		private audioVehicleDoorsSettings _trunk;
		private audioVehicleDoorsSettings _hood;

		[Ordinal(0)] 
		[RED("door")] 
		public audioVehicleDoorsSettings Door
		{
			get => GetProperty(ref _door);
			set => SetProperty(ref _door, value);
		}

		[Ordinal(1)] 
		[RED("trunk")] 
		public audioVehicleDoorsSettings Trunk
		{
			get => GetProperty(ref _trunk);
			set => SetProperty(ref _trunk, value);
		}

		[Ordinal(2)] 
		[RED("hood")] 
		public audioVehicleDoorsSettings Hood
		{
			get => GetProperty(ref _hood);
			set => SetProperty(ref _hood, value);
		}
	}
}
