using static WolvenKit.RED4.Types.Enums;

namespace WolvenKit.RED4.Types
{
	public partial class worldMinimapConfigAreaNode : worldAreaShapeNode
	{
		[Ordinal(4)] 
		[RED("streamingRadius")] 
		public CFloat StreamingRadius
		{
			get => GetPropertyValue<CFloat>();
			set => SetPropertyValue<CFloat>(value);
		}

		public worldMinimapConfigAreaNode()
		{
			Color = new CColor { Red = 255, Green = 178, Blue = 102, Alpha = 120 };
			StreamingRadius = 650.000000F;

			PostConstruct();
		}

		partial void PostConstruct();
	}
}
