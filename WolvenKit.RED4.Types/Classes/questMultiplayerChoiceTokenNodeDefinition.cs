using static WolvenKit.RED4.Types.Enums;

namespace WolvenKit.RED4.Types
{
	[REDMeta]
	public partial class questMultiplayerChoiceTokenNodeDefinition : questSignalStoppingNodeDefinition
	{
		private questMultiplayerChoiceTokenParams _params;

		[Ordinal(2)] 
		[RED("params")] 
		public questMultiplayerChoiceTokenParams Params
		{
			get => GetProperty(ref _params);
			set => SetProperty(ref _params, value);
		}
	}
}
