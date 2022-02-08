using static WolvenKit.RED4.Types.Enums;

namespace WolvenKit.RED4.Types
{
	[REDMeta]
	public partial class gameuiShowCustomTooltipEvent : redEvent
	{
		[Ordinal(0)] 
		[RED("text")] 
		public CString Text
		{
			get => GetPropertyValue<CString>();
			set => SetPropertyValue<CString>(value);
		}

		[Ordinal(1)] 
		[RED("inputAction")] 
		public CString InputAction
		{
			get => GetPropertyValue<CString>();
			set => SetPropertyValue<CString>(value);
		}
	}
}
