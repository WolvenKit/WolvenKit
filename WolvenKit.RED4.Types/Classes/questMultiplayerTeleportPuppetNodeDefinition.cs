using static WolvenKit.RED4.Types.Enums;

namespace WolvenKit.RED4.Types
{
	[REDMeta]
	public partial class questMultiplayerTeleportPuppetNodeDefinition : questSignalStoppingNodeDefinition
	{
		private questMultiplayerTeleportPuppetParams _params;

		[Ordinal(2)] 
		[RED("params")] 
		public questMultiplayerTeleportPuppetParams Params
		{
			get => GetProperty(ref _params);
			set => SetProperty(ref _params, value);
		}
	}
}
