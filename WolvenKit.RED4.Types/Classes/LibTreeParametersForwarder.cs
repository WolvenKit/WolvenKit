using static WolvenKit.RED4.Types.Enums;

namespace WolvenKit.RED4.Types
{
	[REDMeta]
	public partial class LibTreeParametersForwarder : RedBaseClass
	{
		private CArray<CUInt32> _overrides;

		[Ordinal(0)] 
		[RED("overrides")] 
		public CArray<CUInt32> Overrides
		{
			get => GetProperty(ref _overrides);
			set => SetProperty(ref _overrides, value);
		}
	}
}
