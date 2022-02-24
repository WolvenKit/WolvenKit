using static WolvenKit.RED4.Types.Enums;

namespace WolvenKit.RED4.Types
{
	[REDMeta]
	public partial class attrIcon : attrAttribute
	{
		[Ordinal(0)] 
		[RED("onName")] 
		public CString OnName
		{
			get => GetPropertyValue<CString>();
			set => SetPropertyValue<CString>(value);
		}
	}
}
