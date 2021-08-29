using static WolvenKit.RED4.Types.Enums;

namespace WolvenKit.RED4.Types
{
	[REDMeta]
	public partial class Sample_Replicated_String_Property : RedBaseClass
	{
		private CString _property;

		[Ordinal(0)] 
		[RED("property")] 
		public CString Property
		{
			get => GetProperty(ref _property);
			set => SetProperty(ref _property, value);
		}
	}
}
