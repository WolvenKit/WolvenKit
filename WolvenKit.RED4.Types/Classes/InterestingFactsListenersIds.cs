using static WolvenKit.RED4.Types.Enums;

namespace WolvenKit.RED4.Types
{
	[REDMeta]
	public partial class InterestingFactsListenersIds : RedBaseClass
	{
		private CUInt32 _zone;

		[Ordinal(0)] 
		[RED("zone")] 
		public CUInt32 Zone
		{
			get => GetProperty(ref _zone);
			set => SetProperty(ref _zone, value);
		}
	}
}
