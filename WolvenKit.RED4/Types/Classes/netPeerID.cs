using static WolvenKit.RED4.Types.Enums;

namespace WolvenKit.RED4.Types
{
	public partial class netPeerID : RedBaseClass
	{
		[Ordinal(0)] 
		[RED("value")] 
		public CUInt8 Value
		{
			get => GetPropertyValue<CUInt8>();
			set => SetPropertyValue<CUInt8>(value);
		}

		public netPeerID()
		{
			Value = 255;

			PostConstruct();
		}

		partial void PostConstruct();
	}
}
