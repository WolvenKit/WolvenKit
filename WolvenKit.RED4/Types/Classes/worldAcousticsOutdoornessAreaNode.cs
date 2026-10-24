using static WolvenKit.RED4.Types.Enums;

namespace WolvenKit.RED4.Types
{
	public partial class worldAcousticsOutdoornessAreaNode : worldAreaShapeNode
	{
		[Ordinal(4)] 
		[RED("outdoor")] 
		public CFloat Outdoor
		{
			get => GetPropertyValue<CFloat>();
			set => SetPropertyValue<CFloat>(value);
		}

		public worldAcousticsOutdoornessAreaNode()
		{
			Color = new CColor { Red = 139, Green = 69, Blue = 19, Alpha = 128 };

			PostConstruct();
		}

		partial void PostConstruct();
	}
}
