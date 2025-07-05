using static WolvenKit.RED4.Types.Enums;

namespace WolvenKit.RED4.Types
{
	public partial class questRequestVehicleCameraPerspective_NodeType : questIVehicleManagerNodeType
	{
		[Ordinal(0)] 
		[RED("cameraPerspective")] 
		public CEnum<questVehicleCameraPerspective> CameraPerspective
		{
			get => GetPropertyValue<CEnum<questVehicleCameraPerspective>>();
			set => SetPropertyValue<CEnum<questVehicleCameraPerspective>>(value);
		}

		public questRequestVehicleCameraPerspective_NodeType()
		{
			CameraPerspective = Enums.questVehicleCameraPerspective.FPP;

			PostConstruct();
		}

		partial void PostConstruct();
	}
}
