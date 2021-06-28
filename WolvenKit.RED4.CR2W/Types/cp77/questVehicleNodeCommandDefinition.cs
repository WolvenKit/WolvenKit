using WolvenKit.RED4.CR2W.Reflection;
using FastMember;
using static WolvenKit.RED4.CR2W.Types.Enums;

namespace WolvenKit.RED4.CR2W.Types
{
	[REDMeta]
	public class questVehicleNodeCommandDefinition : questAICommandNodeBase
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

		public questVehicleNodeCommandDefinition(IRed4EngineFile cr2w, CVariable parent, string name) : base(cr2w, parent, name) { }
	}
}
