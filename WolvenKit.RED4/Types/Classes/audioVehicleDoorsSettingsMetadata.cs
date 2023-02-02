using static WolvenKit.RED4.Types.Enums;

namespace WolvenKit.RED4.Types
{
	public partial class audioVehicleDoorsSettingsMetadata : RedBaseClass
	{
		[Ordinal(0)] 
		[RED("door")] 
		public audioVehicleDoorsSettings Door
		{
			get => GetPropertyValue<audioVehicleDoorsSettings>();
			set => SetPropertyValue<audioVehicleDoorsSettings>(value);
		}

		[Ordinal(1)] 
		[RED("trunk")] 
		public audioVehicleDoorsSettings Trunk
		{
			get => GetPropertyValue<audioVehicleDoorsSettings>();
			set => SetPropertyValue<audioVehicleDoorsSettings>(value);
		}

		[Ordinal(2)] 
		[RED("hood")] 
		public audioVehicleDoorsSettings Hood
		{
			get => GetPropertyValue<audioVehicleDoorsSettings>();
			set => SetPropertyValue<audioVehicleDoorsSettings>(value);
		}

		public audioVehicleDoorsSettingsMetadata()
		{
			Door = new();
			Trunk = new();
			Hood = new();

			PostConstruct();
		}

		partial void PostConstruct();
	}
}
