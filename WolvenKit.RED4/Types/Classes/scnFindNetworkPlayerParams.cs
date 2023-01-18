using static WolvenKit.RED4.Types.Enums;

namespace WolvenKit.RED4.Types
{
	public partial class scnFindNetworkPlayerParams : RedBaseClass
	{
		[Ordinal(0)] 
		[RED("networkId")] 
		public CUInt32 NetworkId
		{
			get => GetPropertyValue<CUInt32>();
			set => SetPropertyValue<CUInt32>(value);
		}

		public scnFindNetworkPlayerParams()
		{
			PostConstruct();
		}

		partial void PostConstruct();
	}
}
