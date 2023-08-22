using static WolvenKit.RED4.Types.Enums;

namespace WolvenKit.RED4.Types
{
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
			Id = ushort.MaxValue;

			PostConstruct();
		}

		partial void PostConstruct();
	}
}
