using static WolvenKit.RED4.Types.Enums;

namespace WolvenKit.RED4.Types
{
	[REDMeta]
	public partial class gameaudioeventsToggleAimDownSightsEvent : redEvent
	{
		[Ordinal(0)] 
		[RED("toggleOn")] 
		public CBool ToggleOn
		{
			get => GetPropertyValue<CBool>();
			set => SetPropertyValue<CBool>(value);
		}
	}
}
