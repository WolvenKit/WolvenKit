using static WolvenKit.RED4.Types.Enums;

namespace WolvenKit.RED4.Types
{
	[REDMeta]
	public partial class HoverEvent : redEvent
	{
		private CBool _hooverOn;

		[Ordinal(0)] 
		[RED("hooverOn")] 
		public CBool HooverOn
		{
			get => GetProperty(ref _hooverOn);
			set => SetProperty(ref _hooverOn, value);
		}
	}
}
