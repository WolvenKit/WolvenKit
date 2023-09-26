using static WolvenKit.RED4.Types.Enums;

namespace WolvenKit.RED4.Types
{
	public partial class worldMinimapConfigAreaNode : worldAreaShapeNode
	{
		[Ordinal(6)] 
		[RED("streamingRadius")] 
		public CFloat StreamingRadius
		{
			get => GetPropertyValue<CFloat>();
			set => SetPropertyValue<CFloat>(value);
		}

		public worldMinimapConfigAreaNode()
		{
			StreamingRadius = 650.000000F;

			PostConstruct();
		}

		partial void PostConstruct();
	}
}
