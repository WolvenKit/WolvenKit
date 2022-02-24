using static WolvenKit.RED4.Types.Enums;

namespace WolvenKit.RED4.Types
{
	[REDMeta]
	public partial class attrChoice : attrAttribute
	{
		[Ordinal(0)] 
		[RED("tions")] 
		public CArray<CString> Tions
		{
			get => GetPropertyValue<CArray<CString>>();
			set => SetPropertyValue<CArray<CString>>(value);
		}

		public attrChoice()
		{
			Tions = new();
		}
	}
}
