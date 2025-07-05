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

		[Ordinal(4)] 
		[RED("uiFavoriteIndex")] 
		public CInt32 UiFavoriteIndex
		{
			get => GetPropertyValue<CInt32>();
			set => SetPropertyValue<CInt32>(value);
		}

		[Ordinal(5)] 
		[RED("destructionTimeStamp")] 
		public EngineTime DestructionTimeStamp
		{
			get => GetPropertyValue<EngineTime>();
			set => SetPropertyValue<EngineTime>(value);
		}

		public vehiclePlayerVehicle()
		{
			VehicleType = Enums.gamedataVehicleType.Invalid;
			UiFavoriteIndex = -1;
			DestructionTimeStamp = new EngineTime();

			PostConstruct();
		}

		partial void PostConstruct();
	}
}
