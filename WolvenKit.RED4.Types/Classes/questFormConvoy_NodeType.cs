using static WolvenKit.RED4.Types.Enums;

namespace WolvenKit.RED4.Types
{
	public partial class questFormConvoy_NodeType : questIVehicleManagerNodeType
	{
		[Ordinal(0)] 
		[RED("leaderRef")] 
		public gameEntityReference LeaderRef
		{
			get => GetPropertyValue<gameEntityReference>();
			set => SetPropertyValue<gameEntityReference>(value);
		}

		[Ordinal(1)] 
		[RED("formationType")] 
		public CEnum<vehicleFormationType> FormationType
		{
			get => GetPropertyValue<CEnum<vehicleFormationType>>();
			set => SetPropertyValue<CEnum<vehicleFormationType>>(value);
		}

		public questFormConvoy_NodeType()
		{
			LeaderRef = new() { Names = new() };

			PostConstruct();
		}

		partial void PostConstruct();
	}
}
