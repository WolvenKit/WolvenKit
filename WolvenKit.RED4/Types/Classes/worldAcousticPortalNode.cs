using static WolvenKit.RED4.Types.Enums;

namespace WolvenKit.RED4.Types
{
	public partial class worldAcousticPortalNode : worldNode
	{
		[Ordinal(4)] 
		[RED("radius")] 
		public CUInt8 Radius
		{
			get => GetPropertyValue<CUInt8>();
			set => SetPropertyValue<CUInt8>(value);
		}

		[Ordinal(5)] 
		[RED("nominalRadius")] 
		public CUInt8 NominalRadius
		{
			get => GetPropertyValue<CUInt8>();
			set => SetPropertyValue<CUInt8>(value);
		}

		public worldAcousticPortalNode()
		{
			PostConstruct();
		}

		partial void PostConstruct();
	}
}
