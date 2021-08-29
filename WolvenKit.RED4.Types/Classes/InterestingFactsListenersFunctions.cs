using static WolvenKit.RED4.Types.Enums;

namespace WolvenKit.RED4.Types
{
	[REDMeta]
	public partial class InterestingFactsListenersFunctions : RedBaseClass
	{
		private CName _zone;

		[Ordinal(0)] 
		[RED("zone")] 
		public CName Zone
		{
			get => GetProperty(ref _zone);
			set => SetProperty(ref _zone, value);
		}
	}
}
