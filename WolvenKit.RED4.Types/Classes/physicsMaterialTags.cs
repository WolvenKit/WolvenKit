using static WolvenKit.RED4.Types.Enums;

namespace WolvenKit.RED4.Types
{
	[REDMeta]
	public partial class physicsMaterialTags : RedBaseClass
	{
		private CEnum<physicsMaterialTagVisibility> _aiVisibility;
		private CEnum<physicsMaterialTagVisibility> _playerVisibility;
		private CEnum<physicsMaterialTagProjectilePenetration> _projectilePenetration;
		private CEnum<physicsMaterialTagVehicleTraction> _vehicleTraction;

		[Ordinal(0)] 
		[RED("aiVisibility")] 
		public CEnum<physicsMaterialTagVisibility> AiVisibility
		{
			get => GetProperty(ref _aiVisibility);
			set => SetProperty(ref _aiVisibility, value);
		}

		[Ordinal(1)] 
		[RED("playerVisibility")] 
		public CEnum<physicsMaterialTagVisibility> PlayerVisibility
		{
			get => GetProperty(ref _playerVisibility);
			set => SetProperty(ref _playerVisibility, value);
		}

		[Ordinal(2)] 
		[RED("projectilePenetration")] 
		public CEnum<physicsMaterialTagProjectilePenetration> ProjectilePenetration
		{
			get => GetProperty(ref _projectilePenetration);
			set => SetProperty(ref _projectilePenetration, value);
		}

		[Ordinal(3)] 
		[RED("vehicleTraction")] 
		public CEnum<physicsMaterialTagVehicleTraction> VehicleTraction
		{
			get => GetProperty(ref _vehicleTraction);
			set => SetProperty(ref _vehicleTraction, value);
		}
	}
}
