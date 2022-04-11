using static WolvenKit.RED4.Types.Enums;

namespace WolvenKit.RED4.Types
{
	[REDMeta]
	public partial class HoverEvent : redEvent
	{
		[Ordinal(0)] 
		[RED("hooverOn")] 
		public CBool HooverOn
		{
			get => GetPropertyValue<CBool>();
			set => SetPropertyValue<CBool>(value);
		}
	}
}
