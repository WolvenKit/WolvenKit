using static WolvenKit.RED4.Types.Enums;

namespace WolvenKit.RED4.Types
{
	[REDMeta]
	public partial class gameuiPersonalLinkSwitcherEvent : redEvent
	{
		[Ordinal(0)] 
		[RED("isAdvanced")] 
		public CBool IsAdvanced
		{
			get => GetPropertyValue<CBool>();
			set => SetPropertyValue<CBool>(value);
		}
	}
}
