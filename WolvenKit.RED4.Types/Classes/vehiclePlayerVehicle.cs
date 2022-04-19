using static WolvenKit.RED4.Types.Enums;

namespace WolvenKit.RED4.Types
{
	public partial class vehiclePlayerVehicle : RedBaseClass
	{
		[Ordinal(0)] 
		[RED("name")] 
		public CName Name
		{
			get => GetPropertyValue<CName>();
			set => SetPropertyValue<CName>(value);
		}

		[Ordinal(1)] 
		[RED("recordID")] 
		public TweakDBID RecordID
		{
			get => GetPropertyValue<TweakDBID>();
			set => SetPropertyValue<TweakDBID>(value);
		}

		[Ordinal(2)] 
		[RED("vehicleType")] 
		public CEnum<gamedataVehicleType> VehicleType
		{
			get => GetPropertyValue<CEnum<gamedataVehicleType>>();
			set => SetPropertyValue<CEnum<gamedataVehicleType>>(value);
		}

		[Ordinal(3)] 
		[RED("isUnlocked")] 
		public CBool IsUnlocked
		{
			get => GetPropertyValue<CBool>();
			set => SetPropertyValue<CBool>(value);
		}

		public vehiclePlayerVehicle()
		{
			VehicleType = Enums.gamedataVehicleType.Invalid;

			PostConstruct();
		}

		partial void PostConstruct();
	}
}
