using static WolvenKit.RED4.Types.Enums;

namespace WolvenKit.RED4.Types
{
	public partial class worldAreaShapeNode : worldNode
	{
		[Ordinal(4)] 
		[RED("color")] 
		public CColor Color
		{
			get => GetPropertyValue<CColor>();
			set => SetPropertyValue<CColor>(value);
		}

		[Ordinal(5)] 
		[RED("outline")] 
		public CHandle<AreaShapeOutline> Outline
		{
			get => GetPropertyValue<CHandle<AreaShapeOutline>>();
			set => SetPropertyValue<CHandle<AreaShapeOutline>>(value);
		}

		public worldAreaShapeNode()
		{
			Color = new();

			PostConstruct();
		}

		partial void PostConstruct();
	}
}
