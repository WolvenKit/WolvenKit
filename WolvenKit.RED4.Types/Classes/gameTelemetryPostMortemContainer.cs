using static WolvenKit.RED4.Types.Enums;

namespace WolvenKit.RED4.Types
{
	[REDMeta]
	public partial class gameTelemetryPostMortemContainer : ISerializable
	{
		private gameTelemetryPostMortem _postMortem;

		[Ordinal(0)] 
		[RED("postMortem")] 
		public gameTelemetryPostMortem PostMortem
		{
			get => GetProperty(ref _postMortem);
			set => SetProperty(ref _postMortem, value);
		}
	}
}
