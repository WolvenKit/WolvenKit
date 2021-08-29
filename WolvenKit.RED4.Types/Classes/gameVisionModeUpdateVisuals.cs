using static WolvenKit.RED4.Types.Enums;

namespace WolvenKit.RED4.Types
{
	[REDMeta]
	public partial class gameVisionModeUpdateVisuals : redEvent
	{
		private CBool _pulse;

		[Ordinal(0)] 
		[RED("pulse")] 
		public CBool Pulse
		{
			get => GetProperty(ref _pulse);
			set => SetProperty(ref _pulse, value);
		}
	}
}
