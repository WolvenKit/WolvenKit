using static WolvenKit.RED4.Types.Enums;

namespace WolvenKit.RED4.Types
{
	[REDMeta]
	public partial class questFormConvoy_NodeType : questIVehicleManagerNodeType
	{
		private gameEntityReference _leaderRef;
		private CEnum<vehicleFormationType> _formationType;

		[Ordinal(0)] 
		[RED("leaderRef")] 
		public gameEntityReference LeaderRef
		{
			get => GetProperty(ref _leaderRef);
			set => SetProperty(ref _leaderRef, value);
		}

		[Ordinal(1)] 
		[RED("formationType")] 
		public CEnum<vehicleFormationType> FormationType
		{
			get => GetProperty(ref _formationType);
			set => SetProperty(ref _formationType, value);
		}
	}
}
