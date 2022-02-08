using static WolvenKit.RED4.Types.Enums;

namespace WolvenKit.RED4.Types
{
	[REDMeta]
	public partial class LabeledCursorData : inkUserData
	{
		[Ordinal(0)] 
		[RED("text")] 
		public CString Text
		{
			get => GetPropertyValue<CString>();
			set => SetPropertyValue<CString>(value);
		}
	}
}
