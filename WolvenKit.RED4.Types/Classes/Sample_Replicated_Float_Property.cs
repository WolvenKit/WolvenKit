using static WolvenKit.RED4.Types.Enums;

namespace WolvenKit.RED4.Types
{
	[REDMeta]
	public partial class Sample_Replicated_Float_Property : RedBaseClass
	{
		private CFloat _property;

		[Ordinal(0)] 
		[RED("property")] 
		public CFloat Property
		{
			get => GetProperty(ref _property);
			set => SetProperty(ref _property, value);
		}
	}
}
