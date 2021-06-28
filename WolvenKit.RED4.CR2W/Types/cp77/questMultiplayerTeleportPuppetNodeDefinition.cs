using WolvenKit.RED4.CR2W.Reflection;
using FastMember;
using static WolvenKit.RED4.CR2W.Types.Enums;

namespace WolvenKit.RED4.CR2W.Types
{
	[REDMeta]
	public class questMultiplayerTeleportPuppetNodeDefinition : questSignalStoppingNodeDefinition
	{
		private questMultiplayerTeleportPuppetParams _params;

		[Ordinal(2)] 
		[RED("params")] 
		public questMultiplayerTeleportPuppetParams Params
		{
			get => GetProperty(ref _params);
			set => SetProperty(ref _params, value);
		}

		public questMultiplayerTeleportPuppetNodeDefinition(IRed4EngineFile cr2w, CVariable parent, string name) : base(cr2w, parent, name) { }
	}
}
