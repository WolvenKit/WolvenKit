using static WolvenKit.RED4.Types.Enums;

namespace WolvenKit.RED4.Types
{
	[REDMeta]
	public partial class Sample_Replicated_Dynamic_Array_Property : RedBaseClass
	{
		private CArray<CString> _property;

		[Ordinal(0)] 
		[RED("property")] 
		public CArray<CString> Property
		{
			get => GetProperty(ref _property);
			set => SetProperty(ref _property, value);
		}
	}
}
