using static WolvenKit.RED4.Types.Enums;

namespace WolvenKit.RED4.Types
{
	public partial class questEnablePlayerVehicle_NodeType : questIVehicleManagerNodeType
	{
		[Ordinal(0)] 
		[RED("vehicle")] 
		public CString Vehicle
		{
			get => GetPropertyValue<CString>();
			set => SetPropertyValue<CString>(value);
		}

		[Ordinal(1)] 
		[RED("enable")] 
		public CBool Enable
		{
			get => GetPropertyValue<CBool>();
			set => SetPropertyValue<CBool>(value);
		}

		[Ordinal(2)] 
		[RED("despawn")] 
		public CBool Despawn
		{
			get => GetPropertyValue<CBool>();
			set => SetPropertyValue<CBool>(value);
		}

		[Ordinal(3)] 
		[RED("makePlayerActiveVehicle")] 
		public CBool MakePlayerActiveVehicle
		{
			get => GetPropertyValue<CBool>();
			set => SetPropertyValue<CBool>(value);
		}

		public questEnablePlayerVehicle_NodeType()
		{
			Enable = true;
			Despawn = true;
			MakePlayerActiveVehicle = true;

			PostConstruct();
		}

		partial void PostConstruct();
	}
}
