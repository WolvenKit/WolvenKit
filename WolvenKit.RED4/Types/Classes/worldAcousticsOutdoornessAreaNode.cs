using static WolvenKit.RED4.Types.Enums;

namespace WolvenKit.RED4.Types
{
	public partial class worldAcousticsOutdoornessAreaNode : worldAreaShapeNode
	{
		[Ordinal(6)] 
		[RED("outdoor")] 
		public CFloat Outdoor
		{
			get => GetPropertyValue<CFloat>();
			set => SetPropertyValue<CFloat>(value);
		}

		public worldAcousticsOutdoornessAreaNode()
		{
			PostConstruct();
		}

		partial void PostConstruct();
	}
}
