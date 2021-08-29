using static WolvenKit.RED4.Types.Enums;

namespace WolvenKit.RED4.Types
{
	[REDMeta]
	public partial class gameaudioeventsToggleAimDownSightsEvent : redEvent
	{
		private CBool _toggleOn;

		[Ordinal(0)] 
		[RED("toggleOn")] 
		public CBool ToggleOn
		{
			get => GetProperty(ref _toggleOn);
			set => SetProperty(ref _toggleOn, value);
		}
	}
}
