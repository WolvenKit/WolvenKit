using static WolvenKit.RED4.Types.Enums;

namespace WolvenKit.RED4.Types
{
	[REDMeta]
	public partial class Sample_Replicated_Int_Property : RedBaseClass
	{
		private CInt32 _property;

		[Ordinal(0)] 
		[RED("property")] 
		public CInt32 Property
		{
			get => GetProperty(ref _property);
			set => SetProperty(ref _property, value);
		}
	}
}
