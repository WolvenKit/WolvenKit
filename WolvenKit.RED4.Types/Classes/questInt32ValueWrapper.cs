using static WolvenKit.RED4.Types.Enums;

namespace WolvenKit.RED4.Types
{
	[REDMeta]
	public partial class questInt32ValueWrapper : RedBaseClass
	{
		private CHandle<questIInt32ValueProvider> _valueProvider;

		[Ordinal(0)] 
		[RED("valueProvider")] 
		public CHandle<questIInt32ValueProvider> ValueProvider
		{
			get => GetProperty(ref _valueProvider);
			set => SetProperty(ref _valueProvider, value);
		}
	}
}
