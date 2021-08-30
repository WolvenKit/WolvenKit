using static WolvenKit.RED4.Types.Enums;

namespace WolvenKit.RED4.Types
{
	[REDMeta]
	public partial class questRequestVehicleCameraPerspective_NodeType : questIVehicleManagerNodeType
	{
		private CEnum<questVehicleCameraPerspective> _cameraPerspective;

		[Ordinal(0)] 
		[RED("cameraPerspective")] 
		public CEnum<questVehicleCameraPerspective> CameraPerspective
		{
			get => GetProperty(ref _cameraPerspective);
			set => SetProperty(ref _cameraPerspective, value);
		}

		public questRequestVehicleCameraPerspective_NodeType()
		{
			_cameraPerspective = new() { Value = Enums.questVehicleCameraPerspective.FPP };
		}
	}
}
