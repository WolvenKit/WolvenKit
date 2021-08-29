using static WolvenKit.RED4.Types.Enums;

namespace WolvenKit.RED4.Types
{
	[REDMeta]
	public partial class questVehicleNodeCommandDefinition : questAICommandNodeBase
	{
		private gameEntityReference _vehicle;
		private CHandle<questVehicleCommandParams> _commandParams;

		[Ordinal(2)] 
		[RED("vehicle")] 
		public gameEntityReference Vehicle
		{
			get => GetProperty(ref _vehicle);
			set => SetProperty(ref _vehicle, value);
		}

		[Ordinal(3)] 
		[RED("commandParams")] 
		public CHandle<questVehicleCommandParams> CommandParams
		{
			get => GetProperty(ref _commandParams);
			set => SetProperty(ref _commandParams, value);
		}
	}
}
