using static WolvenKit.RED4.Types.Enums;

namespace WolvenKit.RED4.Types
{
	public partial class worldFoliageBrushItem : ISerializable
	{
		[Ordinal(0)] 
		[RED("Mesh")] 
		public CResourceReference<CMesh> Mesh
		{
			get => GetPropertyValue<CResourceReference<CMesh>>();
			set => SetPropertyValue<CResourceReference<CMesh>>(value);
		}

		[Ordinal(1)] 
		[RED("MeshAppearance")] 
		public CName MeshAppearance
		{
			get => GetPropertyValue<CName>();
			set => SetPropertyValue<CName>(value);
		}

		[Ordinal(2)] 
		[RED("Params")] 
		public worldFoliageBrushParams Params
		{
			get => GetPropertyValue<worldFoliageBrushParams>();
			set => SetPropertyValue<worldFoliageBrushParams>(value);
		}

		[Ordinal(3)] 
		[RED("Selected")] 
		public CBool Selected
		{
			get => GetPropertyValue<CBool>();
			set => SetPropertyValue<CBool>(value);
		}

		public worldFoliageBrushItem()
		{
			Params = new worldFoliageBrushParams { Proximity = 1.000000F, Scale = 1.000000F, ScaleVariation = 0.100000F };
			Selected = true;

			PostConstruct();
		}

		partial void PostConstruct();
	}
}
