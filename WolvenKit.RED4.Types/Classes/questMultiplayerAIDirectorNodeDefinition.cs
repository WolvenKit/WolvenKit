using static WolvenKit.RED4.Types.Enums;

namespace WolvenKit.RED4.Types
{
	[REDMeta]
	public partial class questMultiplayerAIDirectorNodeDefinition : questSignalStoppingNodeDefinition
	{
		[Ordinal(2)] 
		[RED("params")] 
		public CHandle<questMultiplayerAIDirectorParams> Params
		{
			get => GetPropertyValue<CHandle<questMultiplayerAIDirectorParams>>();
			set => SetPropertyValue<CHandle<questMultiplayerAIDirectorParams>>(value);
		}

		public questMultiplayerAIDirectorNodeDefinition()
		{
			Sockets = new();
			Id = 65535;
		}
	}
}
