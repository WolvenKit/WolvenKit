using static WolvenKit.RED4.Types.Enums;

namespace WolvenKit.RED4.Types
{
	[REDMeta]
	public partial class attrTooltip : attrAttribute
	{
		[Ordinal(0)] 
		[RED("xt")] 
		public CString Xt
		{
			get => GetPropertyValue<CString>();
			set => SetPropertyValue<CString>(value);
		}
	}
}
