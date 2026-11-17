using static WolvenKit.RED4.Types.Enums;

namespace WolvenKit.RED4.Types
{
	public partial class worldAreaShapeNode : worldNode
	{
		[Ordinal(2)] 
		[RED("color")] 
		public CColor Color
		{
			get => GetPropertyValue<CColor>();
			set => SetPropertyValue<CColor>(value);
		}

		[Ordinal(3)] 
		[RED("outline")] 
		public CHandle<AreaShapeOutline> Outline
		{
			get => GetPropertyValue<CHandle<AreaShapeOutline>>();
			set => SetPropertyValue<CHandle<AreaShapeOutline>>(value);
		}

		public worldAreaShapeNode()
		{
			Color = new CColor { Red = 128, Green = 128, Blue = 96, Alpha = 128 };

			PostConstruct();
		}

		partial void PostConstruct();
	}
}
