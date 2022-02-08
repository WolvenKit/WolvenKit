using static WolvenKit.RED4.Types.Enums;

namespace WolvenKit.RED4.Types
{
	[REDMeta]
	public partial class gameVisionModeUpdateVisuals : redEvent
	{
		[Ordinal(0)] 
		[RED("pulse")] 
		public CBool Pulse
		{
			get => GetPropertyValue<CBool>();
			set => SetPropertyValue<CBool>(value);
		}
	}
}
