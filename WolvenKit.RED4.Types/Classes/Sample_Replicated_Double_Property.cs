using static WolvenKit.RED4.Types.Enums;

namespace WolvenKit.RED4.Types
{
	[REDMeta]
	public partial class Sample_Replicated_Double_Property : RedBaseClass
	{
		private CDouble _property;

		[Ordinal(0)] 
		[RED("property")] 
		public CDouble Property
		{
			get => GetProperty(ref _property);
			set => SetProperty(ref _property, value);
		}
	}
}
