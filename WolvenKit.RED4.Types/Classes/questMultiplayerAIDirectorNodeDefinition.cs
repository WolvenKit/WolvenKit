using static WolvenKit.RED4.Types.Enums;

namespace WolvenKit.RED4.Types
{
	[REDMeta]
	public partial class questMultiplayerAIDirectorNodeDefinition : questSignalStoppingNodeDefinition
	{
		private CHandle<questMultiplayerAIDirectorParams> _params;

		[Ordinal(2)] 
		[RED("params")] 
		public CHandle<questMultiplayerAIDirectorParams> Params
		{
			get => GetProperty(ref _params);
			set => SetProperty(ref _params, value);
		}
	}
}
