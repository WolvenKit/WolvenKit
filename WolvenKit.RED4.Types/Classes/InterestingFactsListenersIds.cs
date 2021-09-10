using static WolvenKit.RED4.Types.Enums;

namespace WolvenKit.RED4.Types
{
	[REDMeta]
	public partial class InterestingFactsListenersIds : RedBaseClass
	{
		[Ordinal(0)] 
		[RED("zone")] 
		public CUInt32 Zone
		{
			get => GetPropertyValue<CUInt32>();
			set => SetPropertyValue<CUInt32>(value);
		}
	}
}
