using static WolvenKit.RED4.Types.Enums;

namespace WolvenKit.RED4.Types
{
	[REDMeta]
	public partial class questTeleportVehicleNodeDefinition : questDisableableNodeDefinition
	{
		private gameEntityReference _entityReference;
		private questTeleportPuppetParams _params;
		private CBool _resetVelocities;

		[Ordinal(2)] 
		[RED("entityReference")] 
		public gameEntityReference EntityReference
		{
			get => GetProperty(ref _entityReference);
			set => SetProperty(ref _entityReference, value);
		}

		[Ordinal(3)] 
		[RED("params")] 
		public questTeleportPuppetParams Params
		{
			get => GetProperty(ref _params);
			set => SetProperty(ref _params, value);
		}

		[Ordinal(4)] 
		[RED("resetVelocities")] 
		public CBool ResetVelocities
		{
			get => GetProperty(ref _resetVelocities);
			set => SetProperty(ref _resetVelocities, value);
		}
	}
}
