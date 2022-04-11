using static WolvenKit.RED4.Types.Enums;

namespace WolvenKit.RED4.Types
{
	[REDMeta]
	public partial class Sample_Replicated_Dynamic_Array_Property : RedBaseClass
	{
		[Ordinal(0)] 
		[RED("property")] 
		public CArray<CString> Property
		{
			get => GetPropertyValue<CArray<CString>>();
			set => SetPropertyValue<CArray<CString>>(value);
		}

		public Sample_Replicated_Dynamic_Array_Property()
		{
			Property = new();
		}
	}
}
