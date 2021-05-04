using WolvenKit.RED4.CR2W.Reflection;
using FastMember;
using static WolvenKit.RED4.CR2W.Types.Enums;

namespace WolvenKit.RED4.CR2W.Types
{
	[REDMeta]
	public class questTeleportVehicleNodeDefinition : questDisableableNodeDefinition
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

		public questTeleportVehicleNodeDefinition(IRed4EngineFile cr2w, CVariable parent, string name) : base(cr2w, parent, name) { }
	}
}
