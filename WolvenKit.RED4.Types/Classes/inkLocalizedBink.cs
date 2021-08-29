using static WolvenKit.RED4.Types.Enums;

namespace WolvenKit.RED4.Types
{
	[REDMeta]
	public partial class inkLocalizedBink : RedBaseClass
	{
		private CArray<inkBinkLanguageDescriptor> _binks;

		[Ordinal(0)] 
		[RED("binks")] 
		public CArray<inkBinkLanguageDescriptor> Binks
		{
			get => GetProperty(ref _binks);
			set => SetProperty(ref _binks, value);
		}
	}
}
